using System;
using System.Collections.Generic;
using TestAutomation.Support;
using Insight.Database;

namespace TestAutomation.Support
{
    public interface IFTCDatabase
    {
        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
				oy.Description AS Description,
				oy.StartDate,
				oy.EndDate
			FROM
				dbo.OrganizationYear oy
			WHERE oy.Description LIKE 'August ' + @year + '%'
        ")]
        SchoolYear GetSchoolYearByStartingYear(string year);

        [Sql(@"
            SELECT TOP 1 Applications.ApplicationID FROM
            (
	            SELECT TOP 1000
		            a.ApplicationID,
		            appstat.Description
	            FROM dbo.Application a
	            JOIN dbo.ApplicationStatus appstat on appstat.ApplicationStatusID = a.ApplicationStatusID
	            WHERE
		            a.ApplicationStatusID = @status
	            AND
		            a.OrganizationYearID = @schoolYear
	            ORDER BY a.ApplicationID DESC
            ) Applications
            ORDER BY NEWID()
        ")]
        int? GetApplicationByStatus(string status, int schoolYear);

        [Sql(@"
			DECLARE @today AS DATETIME = GETDATE()
			SELECT
				oy.OrganizationYearID AS Id,
				oy.Description AS Description,
				oy.StartDate,
				oy.EndDate
			FROM dbo.OrganizationYear oy
			WHERE oy.SchoolYearStartDate < @today
			AND oy.SchoolYearEndDate > @today
        ")]
        SchoolYear GetCurrentSchoolYear();

        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
				oy.Description AS Description,
				oy.StartDate,
				oy.EndDate
			FROM
				dbo.OrganizationYear oy
			WHERE oy.IsActive = 1
        ")]
        SchoolYear GetCurrentlyActiveSchoolYear();

        [Sql(@"
            SELECT
                hm.SocialSecurityNumber,
                pp.EmailAddress,
                h.HouseholdID
            INTO #temp
            FROM dbo.Application a 
            JOIN dbo.Household h
                   ON h.ApplicationID = a.ApplicationID
            JOIN dbo.HouseholdMember hm
                   ON hm.HouseholdID = h.HouseholdID
                   AND hm.HouseholdMemberTypeID = 3
            JOIN student st
                   ON st.HouseholdMemberID = hm.HouseholdMemberID
            JOIN dbo.StudentSchool ss
                   ON ss.HouseholdMemberID = st.HouseholdMemberID
            JOIN dbo.HouseholdMember pp
                   ON pp.HouseholdID = h.HouseholdID
                   AND pp.HouseholdMemberTypeID = 1
            WHERE  ((select sum(Amount) from ScholarshipDistribution where StudentSchoolID = ss.StudentSchoolID) - isnull((select sum(CalculatedAmountOwedToSUFS)from ScholarshipInvoice where StudentSchoolID 
                        = ss.StudentSchoolID),0)) > 0 
            AND a.OrganizationYearID = @yearWithApplication
            AND a.IsFastTrack = @fastTrack
            AND hm.SocialSecurityNumber IS NOT NULL
            AND (SELECT COUNT(*) FROM HouseholdMember HHM1 WHERE HHM1.HouseholdMemberTypeID = 2 AND HHM1.HouseholdID = h.HouseholdID) = @hasSecondaryGuardian
			AND (SELECT COUNT(*) FROM HouseholdMember HHM2 WHERE HHM2.HouseholdMemberTypeID = 3 AND HHM2.HouseholdID = h.HouseholdID) = @numberOfStudents

            SELECT
            hm.SocialSecurityNumber 
            ,pp.EmailAddress
            INTO #temp1
            FROM dbo.Application a 
            JOIN dbo.Household h
                   ON h.ApplicationID = a.ApplicationID
            JOIN dbo.HouseholdMember hm
                   ON hm.HouseholdID = h.HouseholdID
                   AND hm.HouseholdMemberTypeID = 3
            JOIN dbo.HouseholdMember pp
                   ON pp.HouseholdID = h.HouseholdID
                   AND pp.HouseholdMemberTypeID = 1
            AND a.OrganizationYearID = @yearWithoutApplication
            AND hm.SocialSecurityNumber IS NOT NULL

            SELECT TOP 1
            #temp.EmailAddress AS EmailAddress,
            #temp.HouseholdID AS HouseholdId
            FROM #temp
            LEFT JOIN #temp1
            ON #temp1.SocialSecurityNumber = #temp.SocialSecurityNumber
            WHERE #temp1.SocialSecurityNumber IS NULL
            ORDER BY NEWID()

            DROP TABLE #temp
            DROP TABLE  #temp1
        ")]
        RenewalTestGuideData GetRenewalEmailAndHouseholdId(int yearWithApplication, int yearWithoutApplication, int fastTrack = 0, int hasSecondaryGuardian = 0, int numberOfStudents = 1);

        [Sql(@"
            SELECT
	            HHM.MaritalStatusID AS MaritalStatus,
	            (SELECT COUNT(*) FROM HouseholdMember HHM1 WHERE HHM1.HouseholdMemberTypeID IN (1,2) AND HHM1.HouseholdID = @householdId) AS NumberOfGuardians,
	            (SELECT COUNT(*) FROM HouseholdMember HHM2 WHERE HHM2.HouseholdMemberTypeID IN (3) AND HHM2.HouseholdID = @householdId) AS NumberOfStudents,
	            (SELECT COUNT(*) FROM HouseholdMember HHM3 WHERE HHM3.HouseholdMemberTypeID IN (4) AND HHM3.HouseholdID = @householdId) AS NumberOfChildren,
	            (SELECT COUNT(*) FROM HouseholdMember HHM4 WHERE HHM4.HouseholdMemberTypeID IN (5) AND HHM4.HouseholdID = @householdId) AS NumberOfAdults,
	            (SELECT COUNT(*) FROM HouseholdMember HHM5 WHERE HHM5.HouseholdMemberTypeID IN (3) AND HHM5.HouseholdID = @householdId AND HHM5.IsFosterChild = 1) AS NumberOfFosterStudents,
	            (SELECT COUNT(*) FROM HouseholdMember HHM6 WHERE HHM6.HouseholdMemberTypeID IN (4) AND HHM6.HouseholdID = @householdId AND HHM6.IsFosterChild = 1) AS NumberOfFosterChildren
            FROM dbo.HouseholdMember HHM
            WHERE HHM.HouseholdID = @householdId
            AND HHM.HouseholdMemberTypeID = 1
        ")]
        RenewalTestGuideData GetRenewalHouseholdInformation(int householdId);

        [Sql(@"
            SELECT
            	vp.VerificationPeriodID As Id,
	            oy.Description AS SchoolYear,
	            vp.PeriodID AS PeriodId,
	            vpt.ShortDescription AS Type,
	            vp.SchoolID AS SchoolCode,
	            0 AS StudentAwardId,
	            vp.OpenDate AS UnparsedOpenDate,
	            vp.CloseDate AS UnparsedCloseDate,
	            vp.CheckDate AS CheckDate,
	            vp.StartingCheckNumber AS StartingCheckNumber

            FROM dbo.VerificationPeriod vp
            JOIN dbo.OrganizationYear oy ON oy.OrganizationYearID = vp.OrganizationYearID
            JOIN dbo.VerificationPeriodType vpt ON vpt.VerificationPeriodTypeID = vp.VerificationPeriodTypeID
            WHERE oy.OrganizationYearID = @schoolYear
            AND vp.VerificationPeriodTypeID = @type
            AND vp.PeriodID = @periodId
        ")]
        VerificationPeriodData GetVerificationPeriodData(int schoolYear, int periodId, int type = 1);

        [Sql(@"
            SELECT
            	vp.VerificationPeriodID As Id,
	            oy.Description AS SchoolYear,
	            vp.PeriodID AS PeriodId,
	            vpt.ShortDescription AS Type,
	            vp.SchoolID AS SchoolCode,
	            0 AS StudentAwardId,
	            vp.OpenDate AS UnparsedOpenDate,
	            vp.CloseDate AS UnparsedCloseDate,
	            vp.CheckDate AS CheckDate,
	            vp.StartingCheckNumber AS StartingCheckNumber

            FROM dbo.VerificationPeriod vp
            JOIN dbo.OrganizationYear oy ON oy.OrganizationYearID = vp.OrganizationYearID
            JOIN dbo.VerificationPeriodType vpt ON vpt.VerificationPeriodTypeID = vp.VerificationPeriodTypeID
            WHERE oy.OrganizationYearID = @schoolYear
        ")]
        List<VerificationPeriodData> GetAllVRsForSchoolYear(int schoolYear);

        [Sql(@"SELECT cst.Description FROM dbo.CustomerServiceTicketType cst")]
        List<string> GetCustomerServiceTicketTypes();

        [Sql(@"
            SELECT JustGrades.Description AS Type, ISNULL(TuitionsAndGrades.Amount, 0.00) AS Amount FROM
            (
	            SELECT
		            sglt.TuitionTypeOrgYearID,
		            sglt.Amount,
					sglt.SchoolGradeLevelID
	            FROM dbo.SchoolGradeLevelTuition sglt
	            JOIN dbo.SchoolGradeLevel sgl
		            ON sgl.SchoolGradeLevelID = sglt.SchoolGradeLevelID
	            JOIN dbo.TuitionTypeOrgYear ttoy
		            ON ttoy.TuitionTypeOrgYearID = sglt.TuitionTypeOrgYearID
				JOIN dbo.GradeLevel gl
					ON sgl.GradeLevelID = gl.GradeLevelID
	            WHERE ttoy.OrganizationYearID = @organizationYear
	            AND gl.ShortDesc = @gradeLevelId
	            AND sgl.SchoolID = @schoolId
            ) TuitionsAndGrades
            RIGHT JOIN
            (
	            SELECT ttoy.TuitionTypeOrgYearID, tt.Description FROM dbo.TuitionTypeOrgYear ttoy
	            JOIN dbo.TuitionType tt ON tt.TuitionTypeID = ttoy.TuitionTypeID
	            WHERE ttoy.OrganizationYearID = @organizationYear
            ) JustGrades
            ON TuitionsAndGrades.TuitionTypeOrgYearID = JustGrades.TuitionTypeOrgYearID
        ")]
        List<TuitionData> GetTuitionValues(string schoolId, string gradeLevelId, int organizationYear);

        [Sql(@"SELECT s.SchoolID FROM dbo.School s WHERE s.DOESchoolCode = @DoECode")]
        int GetSchoolIDFromDoECode(string DoECode);

        [Sql(@"SELECT s.DOESchoolCode FROM dbo.School s WHERE s.SchoolID = @schoolId")]
        int GetDoECodeFromSchoolID(string schoolId);

        [Sql(@"SELECT SchoolGradeLevelID FROM dbo.SchoolGradeLevel sgl WHERE sgl.SchoolID = @schoolId")]
        List<int> GetGradeLevelsForSchool(string schoolId);

        [Sql(@"
		    SELECT
			    sd.SchoolID,
			    sd.StartDate AS SchoolStartDate,
			    sd.EndDate AS SchoolEndDate,
			    sd.DateVerified AS SchoolComplianceDate,
    			st.Description AS StandardizedTestGiven,
			    sd.StandardizedTestStartDate AS StandardizedTestStartDate,
			    sd.StandardizedTestEndDate AS StandardizedTestEndDate,
			    sd.MultipleSiblingDiscount AS MultiSiblingDiscount,
			    sd.AffiliationDiscount AS AffiliationDiscount
		    FROM dbo.SchoolDetail sd
		    JOIN dbo.StandardizedTest st
			    ON st.StandardizedTestID = sd.StandardizedTestID
		    WHERE sd.SchoolID = @schoolId
		    AND sd.OrganizationYearID = @organizationYear
        ")]
        TuitionAndFeesData GetTuitionAndFeeData(string schoolId, int organizationYear);

        [Sql(@"
            SELECT
	            s.DOESchoolCode
            FROM
	            dbo.School s
            JOIN dbo.StudentSchool ss
	            ON ss.SchoolID = s.SchoolID
            JOIN dbo.HouseholdMember hm
	            ON hm.HouseholdMemberID = ss.HouseholdMemberID
            JOIN dbo.Household h
	            ON h.HouseholdID = hm.HouseholdID
            WHERE
	            h.ApplicationID = @applicationId
        ")]
        List<int> GetSchoolCodesFromApplication(string applicationId);

        [Sql(@"
            SELECT
	            hm.EmailAddress
            FROM HouseholdMember hm
            JOIN dbo.Household h
	            ON h.HouseholdID = hm.HouseholdID
            WHERE
	            h.ApplicationID = @applicationId
            AND
	            hm.HouseholdMemberTypeID = 1
        ")]
        string GetPrimaryGuardianEmailFromApplication(string applicationId);

        [Sql(@"
            SELECT TOP 1
	            Applications.ApplicationId
            FROM
            (
	            SELECT TOP 1000
		            a.ApplicationID
	            FROM dbo.Application a
		            JOIN dbo.household h
			            ON h.ApplicationID = a.ApplicationID
		            JOIN dbo.HouseholdMember hm
			            ON hm.HouseholdID = h.HouseholdID
		            JOIN dbo.Student s
			            ON s.HouseholdMemberID = hm.HouseholdMemberID
	            WHERE a.ApplicationStatusID = @applicationStatus
            		AND a.OrganizationYearID = @schoolYear
		            AND	s.StudentScholarshipStatusID = @studentStatus
	            ORDER BY a.ApplicationID DESC
            ) Applications
            ORDER BY NEWID()
        ")]
        int? GetApplicationByStudentStatus(string studentStatus, int schoolYear, string applicationStatus = "23");

        [Sql(@"
            SELECT top 10
	            addy.AddressFirstLine AS Address1,
	            addy.AddressSecondLine AS Address2,
	            city.Description AS City,
	            'Florida' AS State,
            	'FL' AS StateAbbreviation,
	            addy.Zipcode AS Zip,
	            cnty.Description AS County
            FROM dbo.Address addy
            JOIN dbo.HouseholdAddress ha
	            ON ha.AddressID = addy.AddressID
            JOIN dbo.Household h
	            ON h.HouseholdID = ha.HouseholdID
            JOIN dbo.Application app
	            ON app.ApplicationID = h.ApplicationID
            JOIN dbo.City city
	            ON city.CityID = addy.CityID
            JOIN dbo.County cnty
	            ON cnty.CountyID = addy.CountyID
            WHERE h.ApplicationID = @applicationId
            AND addy.AddressTypeID = 1
        ")]
        AddressData GetMailingAddressForApplication(string applicationId);

        [Sql(@"
            SELECT top 10
	            addy.AddressFirstLine AS Address1,
	            addy.AddressSecondLine AS Address2,
	            city.Description AS City,
	            'Florida' AS State,
            	'FL' AS StateAbbreviation,
	            addy.Zipcode AS Zip,
	            cnty.Description AS County
            FROM dbo.Address addy
            JOIN dbo.HouseholdAddress ha
	            ON ha.AddressID = addy.AddressID
            JOIN dbo.Household h
	            ON h.HouseholdID = ha.HouseholdID
            JOIN dbo.Application app
	            ON app.ApplicationID = h.ApplicationID
            JOIN dbo.City city
	            ON city.CityID = addy.CityID
            JOIN dbo.County cnty
	            ON cnty.CountyID = addy.CountyID
            WHERE h.ApplicationID = @applicationId
            AND addy.AddressTypeID = 2
        ")]
        AddressData GetPhysicalAddressForApplication(string applicationId);

        [Sql(@"
		    SELECT top 1
			    School.ApplicationId
		    FROM
		    (
			    SELECT TOP 1000
				    h.ApplicationID AS ApplicationId
			    FROM dbo.School sch
			    JOIN dbo.StudentSchool ssch
				    ON ssch.SchoolID = sch.SchoolID
			    JOIN dbo.HouseholdMember hm
				    ON hm.HouseholdMemberID = ssch.HouseholdMemberID
			    JOIN dbo.Household h
				    ON h.HouseholdID = hm.HouseholdID
			    JOIN dbo.Application a
				    ON h.ApplicationID = a.ApplicationID
			    JOIN dbo.Student s
				    ON s.HouseholdMemberID = hm.HouseholdMemberID
			    WHERE sch.DOESchoolCode = @doeSchoolCode
				    AND a.ApplicationStatusID = @applicationStatus
				    AND a.OrganizationYearID = @schoolYear
				    AND	s.StudentScholarshipStatusID in (3, 6)
		    ) School
		    ORDER BY NEWID()
        ")]
        int? GetApplicationForSchool(string doeSchoolCode, int schoolYear, string applicationStatus = "23");

        [Sql(@"
            UPDATE householdmember SET HasFreeReducedLunch = 1, UserUpdatedID = 38557, DateUpdated = GETDATE() WHERE householdmemberid IN 
            (SELECT HouseholdmemberID FROM householdmember hm JOIN dbo.Household h ON hm.householdid = h.HouseholdID
            JOIN dbo.Application a ON h.ApplicationID = a.ApplicationID AND a.ApplicationID = @applicationID) AND householdmembertypeid = 3 
        ")]
        void SetFoodStampPingToYes(string applicationId);

        [Sql(@"
	        SELECT
		        appStat.Description
	        FROM dbo.Application a
	        JOIN dbo.ApplicationStatus appstat
		        ON appstat.ApplicationStatusID = a.ApplicationStatusID
	        WHERE
		        a.ApplicationID = @applicationId
	        ORDER BY a.ApplicationID DESC
        ")]
        string GetApplicationStatus(string applicationId);

        [Sql(@"
		    SELECT TOP 1 PaidApplications.ApplicationID
		    FROM
		    (
			    SELECT TOP 1000 at.ApplicationID FROM dbo.ApplicationTransaction at
			    JOIN dbo.Application a
				    ON a.ApplicationID = at.ApplicationID
			    WHERE a.OrganizationYearID = 14
			    AND at.ApplicationTransactionTypeID in (1, 2)
			    GROUP BY at.ApplicationID
			    HAVING COUNT(at.ApplicationID) > 0
			    ORDER BY at.ApplicationID DESC
		    ) PaidApplications
		    ORDER BY NEWID()
        ")]
        int GetApplicationWithPaidFees();

        [Sql(@"
            DECLARE @aspUserID UNIQUEIDENTIFIER
            SELECT @aspUserID = aspU.UserID  FROM aspnet_Users aspU WHERE aspU.UserName = @username
            UPDATE dbo.aspnet_Membership
            SET Password ='aEjrtFJ6B+T2dpD+erAgmBqs33/SVEEz3sY+JEjBb06A4gBdhx5PA1dpXEZpT6LI',
            PasswordSalt ='UCd1461gnSeThYWO7TynAA==', IsLockedOut=0, FailedPasswordAttemptCount=0 , IsApproved=1
            WHERE UserId = @aspUserID
        ")]
        void ResetPassword(string username);

        [Sql(@"
		    SELECT TOP 1 UnclaimedApps.ApplicationId
		    FROM
		    (
			    SELECT
			    DISTINCT a.ApplicationID
			    FROM dbo.Application a 
			    JOIN dbo.Household h
			    ON h.ApplicationID = a.ApplicationID
			    JOIN dbo.HouseholdMember hm
			    ON hm.HouseholdID = h.HouseholdID
			    JOIN student st
			    ON st.HouseholdMemberID = hm.HouseholdMemberID
			    JOIN dbo.StudentScholarshipStatusLog ssl
			    ON ssl.HouseholdMemberID = st.HouseholdMemberID
			    WHERE a.OrganizationYearID = @schoolYearId
			    AND ssl.StudentScholarshipStatusID = 3 ----awarded
			    AND h.HouseholdID NOT IN (
				    SELECT 
				    h2.HouseholdID 
				    FROM dbo.Application a2
				    JOIN household h2
				    ON h2.ApplicationID = a2.ApplicationID
				    JOIN dbo.HouseholdMember hm2
				    ON hm2.HouseholdID = h2.HouseholdID
				    JOIN dbo.StudentScholarshipStatusLog ssl2
				    ON hm2.HouseholdMemberID = ssl2.HouseholdMemberID 		
				    where a2.OrganizationYearID =4
				    AND ssl2.StudentScholarshipStatusID = 6 ---enrolled
			    )
		    ) UnclaimedApps
		    ORDER BY NEWID()
        ")]
        int GetApplicationWithUnusedAward(string schoolYearId);

        [Sql(@"
            SELECT aspMem.UserId
            FROM dbo.aspnet_Membership aspMem
            WHERE aspMem.Email = @email
        ")]
        Guid GetUserIDFromEmail(string email);

        [Sql(@"
		    SELECT TOP 1 NoTnF.SchoolID FROM
		    (
		        SELECT
			        sd.SchoolID
		        FROM dbo.SchoolDetail sd
		        WHERE sd.OrganizationYearID = @schoolYear
			    AND sd.StartDate IS NULL
		    ) NoTnF
		    ORDER BY NEWID()
        ")]
        int? GetSchoolWithNoTnFDataForYear(int schoolYear);

        [Sql(@"
		    SELECT TOP 1 HasTnF.SchoolID FROM
		    (
		        SELECT
			        sgl.SchoolID
	            FROM dbo.SchoolGradeLevelTuition sglt
				JOIN dbo.TuitionTypeOrgYear ttoy
		            ON ttoy.TuitionTypeOrgYearID = sglt.TuitionTypeOrgYearID
				JOIN dbo.TuitionType tt
					ON tt.TuitionTypeID = ttoy.TuitionTypeID
				JOIN dbo.SchoolGradeLevel sgl
					ON sgl.SchoolGradeLevelID = sglt.SchoolGradeLevelID
				JOIN dbo.GradeLevel gl
					ON gl.GradeLevelID = sgl.GradeLevelID AND gl.ShortDesc = @gradeLevel
		        WHERE tt.Description = 'Tuition'
				AND ttoy.OrganizationYearID = @schoolYear
				AND sglt.Amount != 0
		    ) HasTnF
		    ORDER BY NEWID()
        ")]
        int? GetSchoolWithTnFDataForYear(int schoolYear, string gradeLevel);

        [Sql(@"
		    SELECT TOP 1 HasTnF.SchoolID FROM
		    (
		        SELECT
			        sgl.SchoolID
	            FROM dbo.SchoolGradeLevelTuition sglt
				JOIN dbo.TuitionTypeOrgYear ttoy
		            ON ttoy.TuitionTypeOrgYearID = sglt.TuitionTypeOrgYearID
				JOIN dbo.TuitionType tt
					ON tt.TuitionTypeID = ttoy.TuitionTypeID
				JOIN dbo.SchoolGradeLevel sgl
					ON sgl.SchoolGradeLevelID = sglt.SchoolGradeLevelID
				JOIN dbo.GradeLevel gl
					ON gl.GradeLevelID = sgl.GradeLevelID AND gl.ShortDesc = @gradeLevel
		        WHERE tt.Description = 'Tuition'
				AND ttoy.OrganizationYearID = @schoolYear
				AND sglt.Amount != 0
		    ) HasTnF
		    ORDER BY NEWID()
        ")]
        int GetSchoolWithTnFDataForYearAndGrade(int schoolYear, string gradeLevel);

        [Sql(@"
            DECLARE @startDate DateTime
            DECLARE @endDate DateTime
			DECLARE @currentSchoolYearId INT

			SELECT
				@currentSchoolYearId = oy.OrganizationYearID
			FROM
				dbo.OrganizationYear oy
			WHERE oy.IsActive = 1

            SELECT
	            @startDate = oy.StartDate
            FROM dbo.OrganizationYear oy
            WHERE oy.OrganizationYearID = @currentSchoolYearId

            Select @endDate = (@startDate - 1)

            SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description
            FROM dbo.OrganizationYear oy
            WHERE oy.EndDate = @endDate
        ")]
        SchoolYear GetPreviouslyActiveSchoolYear();

        [Sql(@"
			DECLARE @today AS DATETIME = GETDATE()
            DECLARE @startDate DateTime
            DECLARE @endDate DateTime
			DECLARE @currentSchoolYearId INT

			SELECT
				@currentSchoolYearId = oy.OrganizationYearID
			FROM dbo.OrganizationYear oy
			WHERE oy.SchoolYearStartDate < @today
			AND oy.SchoolYearEndDate > @today

            SELECT
	            @startDate = oy.StartDate
            FROM dbo.OrganizationYear oy
            WHERE oy.OrganizationYearID = @currentSchoolYearId

            Select @endDate = (@startDate - 1)

            SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description
            FROM dbo.OrganizationYear oy
            WHERE oy.EndDate = @endDate
        ")]
        SchoolYear GetPreviousSchoolYear();

        [Sql(@"
            DECLARE @startDate DateTime
            DECLARE @endDate DateTime

            SELECT
	            @startDate = oy.StartDate
            FROM dbo.OrganizationYear oy
            WHERE oy.OrganizationYearID = @schoolYearId

            Select @endDate = (@startDate - 1)

            SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description
            FROM dbo.OrganizationYear oy
            WHERE oy.EndDate = @endDate
        ")]
        SchoolYear GetPreviousSchoolYear(int schoolYearId);

        [Sql(@"
            SELECT oys.SettingValue FROM dbo.OrganizationYearSetting oys
            WHERE oys.SettingTypeID = 55
            AND oys.OrganizationYearID = @schoolYearId
        ")]
        string GetScholarshipAwardAmountByYear(int schoolYearId);

        [Sql(@"
            DECLARE @periodId INT

            SELECT @periodId = gsp.GraduationSurveyPeriodID FROM dbo.GraduationSurveyPeriod gsp
            WHERE gsp.OrganizationYearID = @schoolYearId

            DELETE FROM dbo.StudentSchoolGraduationSurveyPeriod
            WHERE GraduationSurveyPeriodID = @periodId

            DELETE FROM dbo.SchoolGraduationSurveyStatus
            WHERE GraduationSurveyPeriodID = @periodId

            DELETE FROM dbo.GraduationSurveyPeriod
            WHERE GraduationSurveyPeriodID = @periodId
        ")]
        void DeleteGraduationSurveyPeriodForSchoolYear(int schoolYearId);

        [Sql(@"
            SELECT TOP 1 Schools.DoESchoolCode
            FROM
            (
	            SELECT distinct
		            st.householdmemberid,
		            gl.description,
		            sch.DOESchoolCode 
	            FROM application a
	            JOIN dbo.Household h
		            ON h.ApplicationID = a.ApplicationID
	            JOIN dbo.HouseholdMember hm
		            ON hm.HouseholdID = h.HouseholdID
	            JOIN student st 
		            ON st.HouseholdMemberID = hm.HouseholdMemberID
	            JOIN dbo.GradeLevel gl
		            ON st.GradeLevelID = gl.GradeLevelID 
	            JOIN studentschool ss
		            ON ss.HouseholdMemberID = st.HouseholdMemberID
		            AND ss.SCFReceivedDate IS NOT NULL 
		            AND ss.EndDate IS NULL
		            AND st.StudentScholarshipStatusID = 6
	            JOIN school sch
		            ON ss.SchoolID = sch.SchoolID 
	            WHERE a.OrganizationYearID = @schoolYearId
	            AND gl.GradeLevelID IN (12,13)
            ) Schools
            ORDER BY NEWID()
        ")]
        int GetSchoolWith11thAnd12thGraders(int schoolYearId);

        [Sql(@"
			SELECT
			    hhm.HouseholdMemberID,
				hhm.FirstName AS FirstName,
				hhm.MiddleName AS MiddleName,
				hhm.LastName AS LastName,
				hhm.EmailAddress AS EmailAddress,
				hmrt.Description AS RelationshipToPrimaryParent,
				hhm.DateOfBirth AS DateofBirth,
				g.Description AS Gender,
				gl.Description AS GradeLevel,
                gl.ShortDesc AS GradeLevelAbbreviation,
				NULL AS SchoolAttended,
				prevSchType.Description AS SchoolType,
				ISNULL(sft.Description, 'None of the Above') AS PriorYearFunding,
				NULL AS SchoolCounty,
				schType.Description AS PlannedSchoolType,
				CASE WHEN hhm.IsFosterChild = 0 THEN 'No' Else 'Yes' END AS Foster,
				CASE WHEN hhm.IsOutOfHome = 0 THEN 'No' Else 'Yes' END AS OOHC
			FROM dbo.HouseholdMember hhm
			JOIN dbo.Gender g
				ON g.GenderID = hhm.GenderID
			JOIN dbo.HouseholdMemberRelationshipType hmrt
				ON hmrt.HouseholdMemberRelationshipTypeID = hhm.HouseholdMemberRelationshipTypeID
			JOIN dbo.Student st
				ON st.HouseholdMemberID = hhm.HouseholdMemberID
			JOIN dbo.GradeLevel gl
				ON gl.GradeLevelId = st.GradeLevelID
			LEFT JOIN dbo.SchoolType prevSchType
				ON prevSchType.SchoolTypeID = st.PreviousSchoolID
			LEFT JOIN dbo.School prevSchool
				ON prevSchool.SchoolTypeID = st.PreviousSchoolID
			LEFT JOIN dbo.SchoolType schType
				ON schType.SchoolTypeID = st.PlannedSchoolTypeID
			LEFT JOIN dbo.SchoolFundingType sft
				ON sft.SchoolFundingTypeID = st.SchoolFundingTypeId
			WHERE hhm.HouseholdId = @householdId
			AND hhm.HouseholdMemberTypeID = 3
        ")]
        List<StudentData> GetStudentDataByHouseholdID(int householdId);

        [Sql(@"
			SELECT
			hhm.HouseholdMemberID,
				hhm.FirstName AS FirstName,
				hhm.MiddleName AS MiddleName,
				hhm.LastName AS LastName,
				hmrt.Description AS RelationshipToPrimaryParent,
				hhm.DateOfBirth AS DateofBirth,
				g.Description AS Gender
			FROM dbo.HouseholdMember hhm
			JOIN dbo.Gender g
				ON g.GenderID = hhm.GenderID
			JOIN dbo.HouseholdMemberRelationshipType hmrt
				ON hmrt.HouseholdMemberRelationshipTypeID = hhm.HouseholdMemberRelationshipTypeID
			WHERE hhm.HouseholdId = @householdId
			AND hhm.HouseholdMemberTypeID = 4
        ")]
        List<ChildData> GetOtherChildDataByHouseholdID(int householdId);

        [Sql(@"
            SELECT
	            r.Description AS Race,
	            hmr.IsSelected AS Selected
            FROM dbo.Race r
            JOIN dbo.HouseholdMemberRace hmr
	            ON hmr.RaceID = r.RaceID
            WHERE HouseholdMemberID = 35203
        ")]
        List<StudentRaceFlag> GetStudentRaceFlags(int householdMemberId);

        [Sql(@"
			SELECT
				hhm.HouseholdMemberID AS HouseholdMemberId,
				hhm.FirstName AS FirstName,
				hhm.MiddleName AS MiddleName,
				hhm.LastName AS LastName,
				hhm.EmailAddress AS EmailAddress,
				ms.Description AS MaritalStatus,
				hmrt.Description AS RelationshipToPrimaryParent,
				lg.Description AS HouseholdLanguage,
				et.Description AS EmploymentStatus,
				emp.Description AS Employer
			FROM dbo.HouseholdMember hhm
			LEFT JOIN dbo.MaritalStatus ms
				ON ms.MaritalStatusID = hhm.MaritalStatusID
			LEFT JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			LEFT JOIN dbo.Language lg
				ON lg.LanguageID = hh.LanguageID
			LEFT JOIN dbo.HouseholdMemberRelationshipType hmrt
				ON hmrt.HouseholdMemberRelationshipTypeID = hhm.HouseholdMemberRelationshipTypeID
			JOIN dbo.EmploymentType et
				ON et.EmploymentTypeID = hhm.EmploymentTypeID
			LEFT JOIN dbo.HouseholdMemberEmployer hhme
				ON hhme.HouseholdMemberID = hhm.HouseholdMemberID
			LEFT JOIN dbo.Employer emp
				ON emp.EmployerID = hhme.EmployerID
			WHERE hhm.HouseholdId = @householdId
			AND hhm.HouseholdMemberTypeID = @householdMemberType
        ")]
        GuardianAdultData GetGuardianDataByHouseholdIdAndType(int householdId, int householdMemberType);

        [Sql(@"
			SELECT
				hhm.HouseholdMemberID AS HouseholdMemberId,
				hhm.FirstName AS FirstName,
				hhm.MiddleName AS MiddleName,
				hhm.LastName AS LastName,
				hmrt.Description AS RelationshipToPrimaryParent,
				et.Description AS EmploymentStatus,
				emp.Description AS Employer
			FROM dbo.HouseholdMember hhm
			LEFT JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			LEFT JOIN dbo.HouseholdMemberRelationshipType hmrt
				ON hmrt.HouseholdMemberRelationshipTypeID = hhm.HouseholdMemberRelationshipTypeID
			JOIN dbo.EmploymentType et
				ON et.EmploymentTypeID = hhm.EmploymentTypeID
			LEFT JOIN dbo.HouseholdMemberEmployer hhme
				ON hhme.HouseholdMemberID = hhm.HouseholdMemberID
			LEFT JOIN dbo.Employer emp
				ON emp.EmployerID = hhme.EmployerID
			WHERE hhm.HouseholdId = @householdId
			AND hhm.HouseholdMemberTypeID = 5
        ")]
        List<AdultData> GetOtherAdultDataByHouseholdId(int householdId);

        [Sql(@"
			SELECT
				addr.AddressFirstLine AS Address1,
				addr.AddressSecondLine AS Address2,
				city.Description AS City,
				'Florida' AS State,
				'FL' AS StateAbbreviation,
				addr.Zipcode AS Zip,
				county.Description AS County
			FROM dbo.HouseholdMember hhm
			JOIN dbo.HouseholdAddress hha
				ON hha.HouseholdID = hhm.HouseholdID
			JOIN dbo.Address addr
				ON addr.AddressID = hha.AddressID
			JOIN dbo.County county
				ON county.CountyID = addr.CountyID
			JOIN dbo.City
				ON city.CityID = addr.CityID
            WHERE hhm.HouseholdMemberId = @householdMemberId
            AND addr.AddressTypeID = @addressType
        ")]
        AddressData GetAddressByHouseoldMemberIdAndType(int householdMemberId, int addressType);

        [Sql(@"
            SELECT
	            pht.Description AS Type,
	            ph.Number AS Number
            FROM dbo.HouseholdMember hhm
            JOIN dbo.HouseholdMemberPhone hhmp
	            ON hhmp.HouseholdMemberID = hhm.HouseholdMemberID
            RIGHT JOIN dbo.Phone ph
	            ON ph.PhoneID = hhmp.PhoneID
            JOIN dbo.PhoneType pht
	            ON pht.PhoneTypeID = ph.PhoneTypeID
            WHERE hhm.HouseholdMemberId = @householdMemberId
        ")]
        List<PhoneNumber> GetPhoneNumbersByHouseholdMemberId(int householdMemberId);

        [Sql(@"
		    SELECT TOP 1 sp.Description FROM dbo.aspnet_Users aspu
		    JOIN dbo.UserMap um
			    ON um.UserId_Membership = aspu.UserId
		    LEFT JOIN dbo.PageView pv
			    ON pv.UserID = um.UserID
		    LEFT JOIN dbo.SitePage sp
			    ON sp.SitePageID = pv.PageID
		    WHERE aspu.UserName = 'karen25268@hotmail.com'
		    order by pv.PageViewID desc
        ")]
        string GetLastVisitiedPageForUser(string userEmail);

        [Sql(@"
            SELECT DISTINCT gradeLvl.schoolid FROM SchoolGradeLevel AS gradeLvl 
            join SchoolGradeLevelTuition sgt ON gradeLvl.SchoolGradeLevelID = sgt.SchoolGradeLevelID
            join TuitionTypeOrgYear ttoy  ON sgt.TuitionTypeOrgYearID = ttoy.TuitionTypeOrgYearID
            where SchoolGradeLevelTuitionStatusId IN (5, 6)--verified-NotAttached 5 or Verified and Attached 6
            AND gradeLvl.SchoolID = @schoolId
            AND  ttoy.OrganizationYearID = @schoolYear
        ")]
        int? TnFValidatedForSchoolInYear(int schoolYear, string schoolId);

        [Sql(@"
			SELECT oys.SettingValue FROM dbo.SettingType st
			JOIN dbo.OrganizationYearSetting oys ON oys.SettingTypeID = st.SettingTypeID
			WHERE st.SettingTypeID = 55
			AND oys.OrganizationYearID = @schoolYear
        ")]
        string GetMaximumScholarshipAmountForYear(int schoolYear);

        [Sql(@"
            SELECT
				gs.GraduationSurveyPeriodID,
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description,
	            gs.OpenDate AS OpenDate,
	            gs.CloseDate AS CloseDate
            FROM
	            dbo.GraduationSurveyPeriod gs
            JOIN dbo.OrganizationYear oy
	            ON oy.OrganizationYearID = gs.OrganizationYearID
            WHERE gs.OrganizationYearID = @schoolYearId
        ")]
        GraduationSurveyData GraduationSurveyForYear(int schoolYearId);

        [Sql(@"
			UPDATE GraduationSurveyPeriod
			SET CloseDate = @newDate
			WHERE GraduationSurveyPeriodID = @graduationSurveyPeriodId
        ")]
        void UpdateGraduationSurveyCloseDate(DateTime newDate, int graduationSurveyPeriodId);

        [Sql(@"
			SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYear oy
			WHERE oy.IsActive = 1
        ")]
        List<SchoolYear> GetActiveSchoolYears();

        [Sql(@"
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'96a025bc-9984-473d-92de-35498f46e66c', 67, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 3, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 4, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 5, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 47, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 48, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 49, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 50, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 59, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 2, 1, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 1, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'9fdafbf4-dc65-43e9-a457-0a62680c29be', 67, 0, 1)
            INSERT INTO dbo.aspnet_RolePermission (RoleID, SitePageSiteControlID, isEditable, isViewable) VALUES (N'96a025bc-9984-473d-92de-35498f46e66c', 1, 0, 1)
        ")]
        void EnableFTCPreScreenPages();

        [Sql(@"
            DELETE FROM dbo.aspnet_RolePermission
            WHERE SitePageSiteControlID in (67, 3, 4, 5, 47, 48, 49, 50, 59, 2, 1, 67, 1)
        ")]
        void DisableFTCPreScreenPages();

        [Sql(@"")]
        string Thing();

        [Sql(@"
            SELECT oys.SettingValue FROM dbo.OrganizationYearSetting oys
            WHERE oys.SettingTypeID = @settingId
            AND OrganizationYearID = @schoolYearId
        ")]
        string GetApplicationSetting(int settingId, int schoolYearId);

        [Sql(@"
            UPDATE dbo.OrganizationYearSetting
            SET SettingValue = @settingValue
            WHERE SettingTypeID = @settingId
            AND OrganizationYearID = @schoolYearId
        ")]
        void SetApplicationSetting(int settingId, string settingValue, int schoolYearId);

        /// <summary>
        /// The gradeShortDescription parameter MUST be the value used in dbo.GradeLevel.ShortDesc
        /// For example, eight grade is 8, pre-kindergarten is PK, etc.
        /// </summary>
        /// <param name="gradeShortDescription"></param>
        /// <returns></returns>
        [Sql(@"
		    SELECT TOP 1
			    NonTLESchools.Name,
			    NonTLESchools.SchoolId,
			    NonTLESchools.DOESchoolCode,
                NULL
		    FROM
		    (
			    SELECT
				    s.Description AS Name,
				    s.SchoolID AS SchoolId,
				    s.DOESchoolCode AS DOESchoolCode
			    FROM dbo.School s
			    JOIN dbo.SchoolDetail sd
				    ON sd.SchoolID = s.SchoolID AND sd.OrganizationYearID = @schoolYear
			    WHERE s.SlcEnabled = 0
			    AND sd.FTCParticipant = 1
			    AND sd.SUFSCertified = 1
				AND EXISTS
				(
					SELECT *
					FROM dbo.Student stdnt
					JOIN dbo.GradeLevel gl
						ON stdnt.GradeLevelID = gl.GradeLevelID
					JOIN dbo.HouseholdMember hhm
						ON hhm.HouseholdMemberID = stdnt.HouseholdMemberID
					JOIN dbo.StudentSchool ss
						ON ss.HouseholdMemberID = hhm.HouseholdMemberID
						AND ss.SchoolID = s.SchoolID
					JOIN dbo.Student s
						ON s.HouseholdMemberID = hhm.HouseholdMemberID
						AND s.StudentScholarshipStatusID = 6
					WHERE gl.ShortDesc IN (@gradeShortDescription)
				)
		    ) NonTLESchools
		    ORDER BY NEWID()
        ")]
        SchoolData GetNonTLESchoolWithStudentsInSpecificGrades(int schoolYear, IEnumerable<string> gradeShortDescription);

        [Sql(@"
            SELECT MAX(Dates.sDate)
            FROM
            (
	            SELECT
		            sd.StartDate AS sDate
	            FROM dbo.SchoolDetail sd
	            JOIN dbo.School s
		            ON s.SchoolID = sd.SchoolID
	            WHERE s.DOESchoolCode = @doeSchoolCode
	            AND sd.OrganizationYearID = @schoolYearId
	            UNION
	            SELECT
		            oy.SchoolYearStartDate AS sDate
	            FROM dbo.OrganizationYear oy
	            WHERE oy.OrganizationYearID = @schoolYearId
            ) Dates
        ")]
        DateTime GetFirstDayOfSchool(int doeSchoolCode, int schoolYearId);

        [Sql(@"
            SELECT MIN(Dates.eDate)
            FROM
            (
	            SELECT
		            sd.EndDate AS eDate
	            FROM dbo.SchoolDetail sd
	            JOIN dbo.School s
		            ON s.SchoolID = sd.SchoolID
	            WHERE s.DOESchoolCode = @doeSchoolCode
	            AND sd.OrganizationYearID = @schoolYearId
	            UNION
	            SELECT
		            oy.SchoolYearEndDate AS eDate
	            FROM dbo.OrganizationYear oy
	            WHERE oy.OrganizationYearID = @schoolYearId
            ) Dates
        ")]
        DateTime GetLastDayOfSchool(int doeSchoolCode, int schoolYearId);

        [Sql(@"
            SELECT s.DOESchoolCode FROM dbo.Application app
            JOIN dbo.Household h
	            ON h.Applicationid = app.ApplicationID
            JOIN dbo.HouseholdMember hm
	            ON hm.HouseholdID = h.HouseholdID
	            AND hm.HouseholdMemberTypeID = 3
            JOIN dbo.StudentSchool ss
	            ON ss.HouseholdMemberID = hm.HouseholdMemberID
            JOIN dbo.School s
	            ON s.SchoolID = ss.SchoolID
            WHERE app.ApplicationID = @applicationId
        ")]
        int GetDOESchoolCodeFromApplicationId(string applicationId);

        [Sql(@"
            SELECT hh.HouseholdID FROM dbo.Household hh
            WHERE hh.ApplicationID = @applicationId
        ")]
        int GetHouseholdIdFromApplicationId(string applicationId);

        [Sql(@"
            SELECT TOP 1
	            nullApps.ApplicationId
            FROM
            (
	            SELECT TOP 1000 hh.ApplicationID FROM dbo.Household hh
	            JOIN dbo.HouseholdMember hhm
		            ON hhm.HouseholdID = hh.HouseholdID AND hhm.HouseholdMemberTypeID = 3
	            JOIN dbo.Application app
		            ON app.ApplicationID = hh.ApplicationID
	            JOIN dbo.Student s
		            ON s.HouseholdMemberID = hhm.HouseholdMemberID
	            WHERE hhm.SocialSecurityNumber IS NULL
		            AND app.OrganizationYearID = 14
		            AND	s.StudentScholarshipStatusID = 6
	            ORDER BY hh.ApplicationID DESC
            ) nullApps
            ORDER BY NEWID()
        ")]
        int? GetApplicationWithNullStudentSSN(int schoolYear);

        [Sql(@"
			SELECT TOP 1 TLEOnlyUsers.Username
			FROM
			(
				SELECT Username, ApplicationId
				FROM dbo.aspnet_Users
				WHERE ApplicationId = '288A1D0E-5B1E-46C9-96BD-652F5731B616' --TLE
				AND
					Username NOT IN
					(
						SELECT
							Username
						FROM
							dbo.aspnet_Users
						WHERE
							ApplicationId = '6D97CCBF-3118-439A-8EBC-83FBD1482F45' -- PLI
					)
			) TLEOnlyUsers
			ORDER BY NEWID()
        ")]
        string GetTLEParentWithoutPLILogin();

        [Sql(@"
		    SELECT TOP 1
			    TLESchools.Name,
			    TLESchools.SchoolId,
			    TLESchools.DOESchoolCode,
                TLESchools.AdminLogin
		    FROM
		    (
                SELECT
                        s.Description AS Name,
                        s.SchoolID AS SchoolId,
                        s.DOESchoolCode AS DOESchoolCode,
                        aspmem.Email AS AdminLogin
                FROM dbo.School s
                JOIN dbo.SchoolDetail sd
                        ON sd.SchoolID = s.SchoolID AND sd.OrganizationYearID = 4
                JOIN TeachingLearningExchange_Test.dbo.UserSchools us
                        ON us.SchoolId = s.SchoolId
                JOIN TeachingLearningExchange_Test.dbo.Users u
                        ON u.UserId = us.UserId
                JOIN dbo.aspnet_Membership aspmem
                        ON aspmem.UserId = u.MembershipUserId
                JOIN dbo.aspnet_UsersInRoles uroles
                        ON uroles.UserId = u.MembershipUserId
                JOIN dbo.aspnet_Roles roles
                        ON roles.RoleId = uroles.RoleId
                        AND roles.RoleId = '6A492FEC-AB18-4C0B-BB55-D03A7F506258'
                WHERE s.SlcEnabled = 1
                AND sd.FTCParticipant = 1
                AND sd.SUFSCertified = 1
				AND aspmem.Email != 'TLEsupport@sufs.org'
				AND NOT EXISTS
				(
					SELECT * FROM dbo.vw_aspnet_UsersInRoles roles2
					WHERE roles2.UserId = uroles.UserId
					and roles2.RoleId = '4A9E888D-B14E-4F7D-A6CC-188AB0E73C1E'
					and roles2.RoleID != '6A492FEC-AB18-4C0B-BB55-D03A7F506258'
				)
		    ) TLESchools
		    ORDER BY NEWID()
        ")]
        SchoolData GetTLESchool(int schoolYear);

        [Sql(@"
			SELECT TOP 1 TLEOnlyUsers.Username
			FROM
			(
				SELECT Username, ApplicationId
				FROM dbo.aspnet_Users
				WHERE ApplicationId = '288A1D0E-5B1E-46C9-96BD-652F5731B616' --TLE
				AND
					Username IN
					(
						SELECT
							Username
						FROM
							dbo.aspnet_Users
						WHERE
							ApplicationId = '6D97CCBF-3118-439A-8EBC-83FBD1482F45' -- PLI
					)
			) TLEOnlyUsers
			ORDER BY NEWID()
        ")]
        string GetTLEParentWithPLILogin();

        [Sql(@"
			SELECT TOP 1
				Applications.Email
			FROM
			(
				SELECT DISTINCT
					am.Email
				FROM dbo.Application AS a
				JOIN dbo.Household AS h ON h.ApplicationID = a.ApplicationID
				JOIN dbo.HouseholdMember AS hm ON hm.HouseholdID = h.HouseholdID
				JOIN dbo.UserApplication AS ua ON ua.ApplicationID = a.ApplicationID
				JOIN dbo.UserMap AS um ON um.UserID = ua.UserID
				JOIN dbo.aspnet_Membership AS am ON am.UserId = um.UserId_Membership
				WHERE a.OrganizationYearID = @schoolYearId
					AND am.UserId NOT IN
					(
						SELECT am.UserId FROM dbo.Application AS a
						JOIN dbo.Household AS h ON h.ApplicationID = a.ApplicationID
						JOIN dbo.HouseholdMember AS hm ON hm.HouseholdID = h.HouseholdID
						JOIN dbo.UserApplication AS ua ON ua.ApplicationID = a.ApplicationID
						JOIN dbo.UserMap AS um ON um.UserID = ua.UserID
						JOIN dbo.aspnet_Membership AS am ON am.UserId = um.UserId_Membership
						WHERE a.OrganizationYearID IN
						(
							SELECT oy.OrganizationYearID
							FROM dbo.OrganizationYear oy
							WHERE oy.OrganizationYearID > @schoolYearId
						)
					)
					AND a.ApplicationStatusID = 1
			) Applications
			ORDER BY NEWID()
        ")]
        string GetInProgressApplicationInYearWithoutSubsequentYears(int schoolYearId);

        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 56
				AND oys.SettingValue = 'true'
        ")]
        List<SchoolYear> GetSchoolYearsAcceptingNew();

        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 58
				AND oys.SettingValue = 'true'
        ")]
        List<SchoolYear> GetSchoolYearsAcceptingRenewal();

        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 70
				AND oys.SettingValue = 'true'
        ")]
        List<SchoolYear> GetSchoolYearsAllowingNewToComplete();

        [Sql(@"
			SELECT
				oy.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 71
				AND oys.SettingValue = 'true'
        ")]
        List<SchoolYear> GetSchoolYearsAllowingRenewalToComplete();

        [Sql(@"
			SELECT
				ss.StudentSchoolId
			FROM dbo.StudentSchool ss
			JOIN dbo.HouseholdMember hhm
				ON hhm.HouseholdMemberID = ss.HouseholdMemberID
			JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			WHERE hh.ApplicationID = @applicationId
        ")]
        int GetStudentSchoolIdFromApplicationId(string applicationId);

        [Sql(@"
            SELECT	oys.SettingValue
            FROM dbo.OrganizationyearSetting oys
            WHERE oys.SettingTypeID = 5
	        AND oys.OrganizationYearID = @schoolYearId
        ")]
        int GetPovertyLevelForYear(int schoolYearId);

        [Sql(@"
		    SELECT COUNT(*) FROM dbo.SiteTabSiteTabSet ststs
		    JOIN dbo.SiteTabSet sts
			    ON sts.SiteTabSetID = ststs.SiteTabSetID
		    WHERE ststs.SiteTabID = 2
		    AND sts.Description = 'SmatApp Public'
		    AND sts.OrganizationYearID = @schoolYearId
        ")]
        int IsPreScreenTabEnabledForYear(int schoolYearId);

        [Sql(@"
            DECLARE @status AS INT

            SELECT @status = appstat.ApplicationStatusID
            FROM dbo.ApplicationStatus appstat
            WHERE appstat.Description = @statusName

            SELECT TOP 1
	            apps.ApplicationID
            FROM
            (
	            SELECT
			        appstl.ApplicationID
	            FROM dbo.ApplicationStatusLog appstl
	            JOIN dbo.ApplicationStatus appstat
			            ON appstat.ApplicationStatusID = appstl.ApplicationStatusID
	            JOIN dbo.Application app
			            ON app.ApplicationID = appstl.ApplicationID
	            WHERE appstl.ApplicationStatusID = @status
	            AND app.ApplicationStatusID = @status
				AND app.OrganizationYearID = @schoolYearId
	            AND
			            ((NOT @rangeStart < 90) OR DATEDIFF(DAY, appstl.DateUpdated, GETDATE()) >= @rangeStart)
			            AND
			            (@rangeStart < 90 OR (DATEDIFF(DAY, appstl.DateUpdated, GETDATE()) >= @rangeStart) AND DATEDIFF(DAY, appstl.DateUpdated, GETDATE()) < @rangeStart + 30)
            ) AS apps
            ORDER BY NEWID()
        ")]
        int? GetApplicationByTimeInStatus(string statusName, int rangeStart, int schoolYearId);

        [Sql(@"
			DECLARE @today AS DATE
			SELECT @today = CAST(GETDATE() AS DATE)

			SELECT ds.DocumentName, ds.UploadDate, @today
			FROM dbo.DocumentStorage ds 
			LEFT JOIN dbo.ApplicationSupportingDocumentStorage asds
				ON asds.DocumentStorageID = ds.DocumentStorageID
			LEFT JOIN dbo.ApplicationSupportingDocument asd
				ON asd.ApplicationSupportingDocumentID = asds.ApplicationSupportingDocumentID
			WHERE ds.DocumentName LIKE '%Automated Regression%'
			AND asd.ApplicationID = @applicationId
			AND CAST(ds.UploadDate AS DATE) = @today
        ")]
        List<string> GetNumberOfAttachedFaxesForToday(string applicationId);

        [Sql(@"
            SELECT VP.VerificationPeriodID FROM dbo.VerificationPeriod VP
            JOIN dbo.Period P ON P.PeriodID = VP.PeriodID
            WHERE VP.OpenDate <= GETDATE() AND VP.CloseDate > GETDATE() AND VP.RemoveDate IS NULL
        ")]
        int? GetCurrentVerificationPeriod();

        [Sql(@"
            SELECT DISTINCT RIGHT('000'+CAST(S.DOESchoolCode AS VARCHAR(4)),4) FROM dbo.School S
            JOIN dbo.StudentSchool SS ON S.SchoolID = SS.SchoolID
            JOIN dbo.SchoolDetail SD ON SD.SchoolID = S.SchoolID
            JOIN dbo.VerificationPeriod VP ON SD.OrganizationYearID = VP.OrganizationYearID
            WHERE SS.BeginDate >= SD.StartDate AND SS.EndDate <= SD.EndDate AND VP.VerificationPeriodID = @verificationPeriodId
        ")]
        List<string> GetSchoolsWithStudentsForVerificationPeriod(int verificationPeriodId);
    }
}
