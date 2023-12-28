using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Support;
using Insight.Database;

namespace TestAutomation.Support
{
    public interface IPLSADatabase
    {
        [Sql(@"
            SELECT aspMem.UserId
            FROM dbo.aspnet_Membership aspMem
            WHERE aspMem.Email = @email
        ")]
        Guid GetUserIDFromEmail(string email);

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
	            oy.Description AS Description,
				oy.SchoolYearStartDate AS StartDate,
				oy.SchoolYearEndDate AS EndDate
            FROM dbo.OrganizationYear oy
            WHERE oy.EndDate = @endDate
        ")]
        SchoolYear GetPreviousSchoolYear();

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
	            oy.Description AS Description,
				oy.SchoolYearStartDate AS StartDate,
				oy.SchoolYearEndDate AS EndDate
            FROM dbo.OrganizationYear oy
            WHERE oy.EndDate = @endDate
        ")]
        SchoolYear GetPreviouslyActiveSchoolYear();

        [Sql(@"
			DECLARE @today AS DATETIME = GETDATE()
			SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description,
				oy.SchoolYearStartDate AS StartDate,
				oy.SchoolYearEndDate AS EndDate
			FROM dbo.OrganizationYear oy
			WHERE oy.SchoolYearStartDate < @today
			AND oy.SchoolYearEndDate > @today
        ")]
        SchoolYear GetCurrentSchoolYear();

        [Sql(@"
			SELECT TOP 1
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description,
				oy.SchoolYearStartDate AS StartDate,
				oy.SchoolYearEndDate AS EndDate
			FROM
				dbo.OrganizationYear oy
			WHERE oy.IsActive = 1
			ORDER BY oy.OrganizationYearID ASC
        ")]
        SchoolYear GetCurrentlyActiveSchoolYear();

        [Sql(@"
			SELECT
	            oy.OrganizationYearID AS Id,
	            oy.Description AS Description,
				oy.SchoolYearStartDate AS StartDate,
				oy.SchoolYearEndDate AS EndDate
			FROM dbo.OrganizationYear oy
			WHERE oy.IsActive = 1
        ")]
        List<SchoolYear> GetActiveSchoolYears();

        [Sql(@"
            SELECT TOP 1
            Students.ApplicationId,
            Students.HouseholdMemberId
            FROM
            (
	            SELECT DISTINCT
		            hh.ApplicationID AS ApplicationId,
		            hhm.HouseholdMemberId AS HouseholdMemberId
	            FROM dbo.StudentDiagnosisType s
	            JOIN dbo.HouseholdMember hhm
		            ON hhm.HouseholdMemberID = s.HouseholdMemberID
	            JOIN dbo.Household hh
		            ON hh.HouseholdID = hhm.HouseholdID
				JOIN dbo.Application a
					ON a.ApplicationID = hh.ApplicationID
	            WHERE exists (
		            SELECT 1
		            FROM dbo.StudentDiagnosisType sd
		            JOIN dbo.DiagnosisType dt
			            ON dt.DiagnosisTypeID = sd.DiagnosisTypeID
		            WHERE s.HouseholdMemberID = sd.HouseholdMemberID
		            AND dt.Description IN (@conditionString)
		            GROUP BY sd.HouseholdMemberID
		            HAVING count(*) > 1
	            )
				AND a.OrganizationYearID = @schoolYear
            ) Students
            ORDER BY NEWID()
        ")]
        PLSAHouseholdMember GetStudentWithSpecificConditions(IEnumerable<string> conditionString, int schoolYear);

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
		    SELECT TOP 1
			    Renewables.EmailAddress,
			    Renewables.HouseholdID
		    FROM
		    (
                SELECT
                pp.EmailAddress,
                h.HouseholdID
                FROM dbo.Application a 
                JOIN dbo.Household h
                       ON h.ApplicationID = a.ApplicationID
                JOIN dbo.HouseholdMember hm
                       ON hm.HouseholdID = h.HouseholdID
                       AND hm.HouseholdMemberTypeID = 3
                JOIN student st
                       ON st.HouseholdMemberID = hm.HouseholdMemberID
                JOIN dbo.HouseholdMember pp
                       ON pp.HouseholdID = h.HouseholdID
                       AND pp.HouseholdMemberTypeID = 1
                WHERE a.OrganizationYearID = @priorSchoolYear
                AND hm.SocialSecurityNumber IS NOT NULL
			    AND st.StudentScholarshipStatusID = @lastYearStudentStatus
                AND (SELECT COUNT(*) FROM HouseholdMember HHM1 WHERE HHM1.HouseholdMemberTypeID = 2 AND HHM1.HouseholdID = h.HouseholdID) = @hasSecondaryGuardian
			    AND (SELECT COUNT(*) FROM HouseholdMember HHM2 WHERE HHM2.HouseholdMemberTypeID = 3 AND HHM2.HouseholdID = h.HouseholdID) = @numberOfStudents
			    AND hm.SocialSecurityNumber Not In
			    (
				    SELECT
				    hm1.SocialSecurityNumber
				    FROM dbo.Application a1
				    JOIN dbo.Household h1
					       ON h1.ApplicationID = a1.ApplicationID
				    JOIN dbo.HouseholdMember hm1
					       ON hm1.HouseholdID = h1.HouseholdID
					       AND hm1.HouseholdMemberTypeID = 3
				    JOIN dbo.HouseholdMember pp1
					       ON pp1.HouseholdID = h1.HouseholdID
					       AND pp1.HouseholdMemberTypeID = 1
				    AND a1.OrganizationYearID = @currentSchoolYear
				    AND hm1.SocialSecurityNumber IS NOT NULL
			    )
				AND
				(
					SELECT count(*) FROM dbo.aspnet_Users aspu
					JOIN dbo.UserMap um
						ON um.UserId_Membership = aspu.UserId
					JOIN dbo.UserApplication ua
						ON ua.UserID = um.UserID
					WHERE aspu.Username = pp.EmailAddress
				) = 1
		    ) Renewables
		    ORDER BY NEWID()
        ")]
        RenewalTestGuideData GetRenewableApplication(int priorSchoolYear, int currentSchoolYear, int hasSecondaryGuardian = 0, int numberOfStudents = 1, int lastYearStudentStatus = 3);

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
				NULL AS SchoolAttended,
				prevSchType.Description AS SchoolType,
				ISNULL(sft.Description, 'None of the Above') AS PriorYearFunding,
				NULL AS SchoolCounty,
				schType.Description AS PlannedSchoolType
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
        List<PLSAStudentData> GetStudentDataByHouseholdID(int householdId);

        [Sql(@"
			SELECT
				dt.Description
			FROM dbo.StudentDiagnosisType sdt
			JOIN dbo.DiagnosisType dt
				ON dt.DiagnosisTypeID = sdt.DiagnosisTypeID
			WHERE sdt.HouseholdMemberID = @householdMemberId
        ")]
        List<string> GetStudentDisabilities(int householdMemberId);

        [Sql(@"
            SELECT
	            r.Description AS Race,
	            hmr.IsSelected AS Selected
            FROM dbo.Race r
            JOIN dbo.HouseholdMemberRace hmr
	            ON hmr.RaceID = r.RaceID
            WHERE HouseholdMemberID = @householdMemberId
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
				lg.Description AS HouseholdLanguage
			FROM dbo.HouseholdMember hhm
			LEFT JOIN dbo.MaritalStatus ms
				ON ms.MaritalStatusID = hhm.MaritalStatusID
			LEFT JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			LEFT JOIN dbo.Language lg
				ON lg.LanguageID = hh.LanguageID
			LEFT JOIN dbo.HouseholdMemberRelationshipType hmrt
				ON hmrt.HouseholdMemberRelationshipTypeID = hhm.HouseholdMemberRelationshipTypeID
			WHERE hhm.HouseholdId = @householdId
			AND hhm.HouseholdMemberTypeID = @householdMemberType
        ")]
        GuardianAdultData GetGuardianDataByHouseholdIdAndType(int householdId, int householdMemberType);

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
		    WHERE aspu.UserName = @userEmail
		    order by pv.PageViewID desc
        ")]
        string GetLastVisitiedPageForUser(string userEmail);

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
            SELECT TOP 1 Applications.ApplicationID FROM
            (
	            SELECT TOP 1000
		            a.ApplicationID,
		            appstat.Description
	            FROM dbo.Application a
	            JOIN dbo.ApplicationStatus appstat on appstat.ApplicationStatusID = a.ApplicationStatusID
				JOIN dbo.Household h on h.ApplicationID = a.ApplicationID
				JOIN dbo.HouseholdMember hhm on hhm.HouseholdID = h.HouseholdID
					AND hhm.HouseholdMemberTypeID = 3
				JOIN dbo.Student s ON s.HouseholdMemberID = hhm.HouseholdMemberID
					AND s.StudentScholarshipStatusID IN (1, 2, 3)
	            WHERE
		            a.ApplicationStatusID in (@status)
	            AND
		            a.OrganizationYearID = @schoolYear
				AND
					a.ApplicationTypeID = @type
	            ORDER BY a.ApplicationID DESC
            ) Applications
            ORDER BY NEWID()
        ")]
        int? GetApplicationByStatus(IEnumerable<string> status, int type, int schoolYear);

        [Sql(@"
            SELECT h.HouseholdID FROM dbo.Household h
            JOIN dbo.Application a ON a.ApplicationID = h.ApplicationID
            WHERE h.ApplicationID = @applicationId
            AND a.OrganizationYearID = @schoolYear
        ")]
        int GetHouseholdIDFromApplicationID(string applicationId, int schoolYear);

        [Sql(@"
            SELECT dr.Description FROM dbo.DenialReason dr
            JOIN dbo.DenialReasonOrgYear droy
	            ON droy.DenialReasonID = dr.DenialReasonID
            WHERE droy.OrganizationYearID = @schoolYear
			AND dr.DenialReasonTypeID = 1
        ")]
        List<string> GetDenialReasonsForSchoolYear(int schoolYear);

        [Sql(@"
            SELECT hr.Description FROM dbo.HoldReason hr
            JOIN dbo.HoldReasonOrgYear hroy
	            ON hroy.HoldReasonID = hr.HoldReasonID
            WHERE hroy.OrganizationYearID = @schoolYear
			AND hr.HoldReasonTypeID = 1
        ")]
        List<string> GetHoldReasonsForSchoolYear(int schoolYear);

        [Sql(@"
		    SELECT TOP 1
			    Renewables.EmailAddress,
			    Renewables.HouseholdID
		    FROM
		    (
                SELECT
                pp.EmailAddress,
                h.HouseholdID
                FROM dbo.Application a 
                JOIN dbo.Household h
                       ON h.ApplicationID = a.ApplicationID
                JOIN dbo.HouseholdMember hm
                       ON hm.HouseholdID = h.HouseholdID
                       AND hm.HouseholdMemberTypeID = 3
                JOIN student st
                       ON st.HouseholdMemberID = hm.HouseholdMemberID
                JOIN dbo.HouseholdMember pp
                       ON pp.HouseholdID = h.HouseholdID
                       AND pp.HouseholdMemberTypeID = 1
                WHERE a.OrganizationYearID = 4
                AND hm.SocialSecurityNumber IS NOT NULL
			    AND st.StudentScholarshipStatusID = 3
                AND (SELECT COUNT(*) FROM HouseholdMember HHM1 WHERE HHM1.HouseholdMemberTypeID = 2 AND HHM1.HouseholdID = h.HouseholdID) = @hasSecondaryGuardian
			    AND (SELECT COUNT(*) FROM HouseholdMember HHM2 WHERE HHM2.HouseholdMemberTypeID = 3 AND HHM2.HouseholdID = h.HouseholdID) = @numberOfStudents
			    AND hm.SocialSecurityNumber Not In
			    (
				    SELECT
				    hm1.SocialSecurityNumber
				    FROM dbo.Application a1
				    JOIN dbo.Household h1
					       ON h1.ApplicationID = a1.ApplicationID
				    JOIN dbo.HouseholdMember hm1
					       ON hm1.HouseholdID = h1.HouseholdID
					       AND hm1.HouseholdMemberTypeID = 3
				    JOIN dbo.HouseholdMember pp1
					       ON pp1.HouseholdID = h1.HouseholdID
					       AND pp1.HouseholdMemberTypeID = 1
				    AND a1.OrganizationYearID = 14
				    AND hm1.SocialSecurityNumber IS NOT NULL
			    )
				AND
				(
					SELECT count(*) FROM dbo.aspnet_Users aspu
					JOIN dbo.UserMap um
						ON um.UserId_Membership = aspu.UserId
					JOIN dbo.UserApplication ua
						ON ua.UserID = um.UserID
					WHERE aspu.Username = pp.EmailAddress
				) = 1
				AND EXISTS
				(
		            SELECT 1
		            FROM dbo.StudentDiagnosisType sd
		            JOIN dbo.DiagnosisType dt
			            ON dt.DiagnosisTypeID = sd.DiagnosisTypeID
		            WHERE hm.HouseholdMemberID = sd.HouseholdMemberID
		            AND dt.Description = @condition
				)
		    ) Renewables
		    ORDER BY NEWID()
        ")]
        RenewalTestGuideData GetRenewableApplicationWhereStudentHasSpecificCondition(string condition, int hasSecondaryGuardian = 0, int numberOfStudents = 1);

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
            SELECT
	            h.ApplicationId, a.OrganizationYearID
            FROM HouseholdMember hm
            JOIN dbo.Household h
	            ON h.HouseholdID = hm.HouseholdID
			JOIN dbo.Application a
				ON a.ApplicationId = h.ApplicationID
            WHERE hm.EmailAddress = @email
            AND hm.HouseholdMemberTypeID = 1
			AND a.OrganizationYearID = @schoolYearId
        ")]
        int? GetApplicationIdFromPrimaryGuardianEmail(string email, int schoolYearId);

        [Sql(@"
            SELECT DISTINCT
	            app.ApplicationId AS ApplicationId,
	            app.OrganizationYearID AS SchoolYearId
            FROM dbo.Application app
            JOIN dbo.Household h
	            ON h.ApplicationID = app.ApplicationID
            JOIN dbo.HouseholdMember hm
	            ON hm.HouseholdID = h.HouseholdID
            WHERE hm.EmailAddress = @email
        ")]
        List<PLSAApplicationData> GetAllApplicationsAssociatedWithPrimaryGuardianEmail(string email);

        [Sql(@"
			SELECT
				oys.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 56
				AND oys.SettingValue = 'true'
        ")]
        SchoolYear GetSchoolYearAcceptingNew();

        [Sql(@"
			SELECT
				oys.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 58
				AND oys.SettingValue = 'true'
        ")]
        SchoolYear GetSchoolYearAcceptingRenewal();

        [Sql(@"
			SELECT
				oys.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 70
				AND oys.SettingValue = 'true'
        ")]
        SchoolYear GetSchoolYearAllowingNewToComplete();

        [Sql(@"
			SELECT
				oys.OrganizationYearID AS Id,
	            oy.Description AS Description
			FROM dbo.OrganizationYearSetting AS oys
			JOIN dbo.OrganizationYear oy
			on oy.OrganizationYearID = oys.OrganizationYearID
			WHERE oys.SettingTypeID = 71
				AND oys.SettingValue = 'true'
        ")]
        SchoolYear GetSchoolYearAllowingRenewalToComplete();

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

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE p.GroupID = @providerId
			AND c.ClaimStatusID = 8
			AND  DATEDIFF(DAY,c.DateUpdated,GETDATE()) >= 10
			AND ci.ClaimItemStatusID != 3
			GROUP BY c.ClaimID
        ")]
        List<int> GetPaidReimbursementsForProvider(int providerId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE p.GroupID = @providerId
			AND c.ClaimStatusID != 8
			GROUP BY c.ClaimID
        ")]
        List<int> GetInProcessReimbursementsForProvider(int providerId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE p.GroupID = @providerId
			AND c.ClaimStatusID = 8
			AND  DATEDIFF(DAY,c.DateUpdated,GETDATE()) < 10
			AND ci.ClaimItemStatusID != 3
			GROUP BY c.ClaimID
        ")]
        List<int> GetPendingPaymentReimbursementsForProvider(int providerId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE p.GroupID = @providerId
			AND c.ClaimStatusID = 8
			AND NOT EXISTS
			(
				SELECT *
				FROM dbo.ClaimItem ci2
				WHERE ci2.ClaimID = ci.ClaimID
				AND ci2.ClaimItemStatusID != 3
			)
			GROUP BY c.ClaimID
        ")]
        List<int> GetDeniedReimbursementsForProvider(int providerId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE c.HouseholdMemberID = @householdMemberId
			AND c.ClaimStatusID = 8
			AND  DATEDIFF(DAY,c.DateUpdated,GETDATE()) >= 10
			AND ci.ClaimItemStatusID !=3
			GROUP BY c.ClaimID
        ")]
        List<int> GetPaidReimbursementsForStudent(string householdMemberId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE c.HouseholdMemberID = @householdMemberId
			AND c.ClaimStatusID != 8
        ")]
        List<int> GetInProcessReimbursementsForStudent(string householdMemberId, int schoolYearId);

        [Sql(@"
			SELECT
				c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			JOIN dbo.Provider p
				ON c.providerid = p.providerid
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE p.GroupID = @householdMemberId
			AND c.ClaimStatusID = 8
			AND  DATEDIFF(DAY,c.DateUpdated,GETDATE()) < 10
			AND ci.ClaimItemStatusID !=3
			GROUP BY c.ClaimID
        ")]
        List<int> GetPendingPaymentReimbursementsForStudent(string householdMemberId, int schoolYearId);

        [Sql(@"
            SELECT
	            c.ClaimID
            FROM dbo.Claim c
            JOIN dbo.ClaimItem ci
	            ON ci.ClaimID = c.ClaimID
            JOIN dbo.ClaimStatus cs
	            ON cs.ClaimStatusID = c.ClaimStatusID
            INNER JOIN dbo.OrganizationYear oy
	            ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
	            AND oy.OrganizationYearID = @schoolYearId
            WHERE c.HouseholdMemberID = @householdMemberId
            AND c.ClaimStatusID = 8
            AND NOT EXISTS
            (
	            SELECT *
	            FROM dbo.ClaimItem ci2
	            WHERE ci2.ClaimID = ci.ClaimID
	            AND ci2.ClaimItemStatusID != 3
            )
            GROUP BY c.ClaimID
        ")]
        List<int> GetDeniedReimbursementsForStudent(string householdMemberId, int schoolYearId);

        [Sql(@"
			SELECT
	            c.ClaimID
			FROM dbo.Claim c
			JOIN dbo.ClaimItem ci
				ON ci.ClaimID = c.ClaimID
			JOIN dbo.ClaimStatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			INNER JOIN dbo.OrganizationYear oy
				ON ISNULL(c.ServiceDate, c.DateCreated) BETWEEN oy.FiscalYearStartDate AND oy.FiscalYearEndDate
				AND oy.OrganizationYearID = @schoolYearId
			WHERE c.HouseholdMemberID = @householdMemberId
			AND c.ClaimTypeID = 2
            GROUP BY c.ClaimID
        ")]
        List<int> GetAuthorizationsForStudent(string householdMemberId, int schoolYearId);

        [Sql(@"
			SELECT TOP 1 Applications.ApplicationId
			FROM
			(
				SELECT
					h.ApplicationID
				FROM SAPAwards.ECSB1_StudentAccounts sa
				JOIN dbo.HouseholdMember student
					ON student.PersonID = sa.StudentID
				JOIN dbo.Household h
					ON h.HouseholdID = student.HouseholdID
				JOIN dbo.Student std
					ON std.HouseholdMemberID = student.HouseholdMemberID
					AND std.StudentScholarshipStatusID = 3
				JOIN dbo.HouseholdMember parent
					ON parent.HouseholdID = h.HouseholdID
					AND parent.HouseholdMemberTypeID = 1
				WHERE sa.CurrentYearFunded > sa.CurrentYearPaid
				GROUP BY h.ApplicationId
			) Applications
			ORDER BY NEWID()
        ")]
        int GetApplicationWithAvailableFunding();

        [Sql(@"
            
            SELECT
	            hhm.PersonId
            FROM dbo.HouseholdMember hhm
            JOIN dbo.Household hh
	            ON hh.HouseholdId = hhm.HouseholdId
	            AND hh.ApplicationId = @applicationId
            WHERE hhm.HouseholdMemberTypeId = 3
        ")]
        int GetStudentIdFromApplication(string applicationId);

        /// <summary>
        /// Use the following values for submitter:
        /// 1 - Guardian
        /// 2 - Provider
        /// Use the following values for payee:
        /// 1 - Myself
        /// 2 - Provider
        /// </summary>
        /// <param name="submitter"></param>
        /// <param name="payee"></param>
        /// <returns>PLSAReimbursementData object representing a reimbursement request</returns>
        [Sql(@"
			SELECT TOP 1
				c.ClaimId AS Id,
				hhm.PersonID AS StudentId,
                c.HouseholdMemberId,
				COALESCE(hhm.EmailAddress, parent.EmailAddress) AS Email,
				hhm.FullName AS StudentName,
				pvd.Description AS ProviderName
			FROM dbo.Claim c
			JOIN dbo.claimstatus cs
				ON cs.ClaimStatusID = c.ClaimStatusID
			JOIN dbo.Provider pvd
				ON pvd.ProviderID = c.ProviderID
			JOIN dbo.HouseholdMember hhm
				ON hhm.HouseholdMemberID = c.HouseholdMemberID
			JOIN dbo.Household hh
				ON hh.HouseholdId = hhm.HouseholdID
			JOIN dbo.HouseholdMember parent
				ON parent.HouseholdID = hh.HouseholdID
				AND parent.HouseholdMemberTypeID = 1
			WHERE c.PayTypeId = @payee
			AND c.ClaimOriginationTypeID = @submitter
			AND c.ClaimStatusId IN (1,2)
			AND c.ClaimTypeId = 1
			AND EXISTS
			(
				SELECT
					P.EmailAddress AS ProviderEmail
				FROM dbo.Provider AS P
					LEFT JOIN dbo.UserProvider AS UP ON UP.ProviderID = P.ProviderID
					LEFT JOIN dbo.UserMap AS UM ON UM.UserID = UP.UserID
					LEFT JOIN dbo.aspnet_Users AS AU ON AU.UserId = UM.UserId_Membership
				WHERE AU.UserId IS NOT NULL
				AND P.ProviderID = pvd.ProviderID
				AND P.ProviderApprovalStatusID = 3
			)
			AND EXISTS
			(
				SELECT * FROM
				dbo.ClaimItem ci
				WHERE ci.CLaimId = c.ClaimId
			)
			ORDER BY NEWID()
        ")]
        PLSAReimbursementData GetInProcessReimbursementBySubmitterAndPayee(int submitter, int payee);

        [Sql(@"
			SELECT
				ci.ClaimItemID AS Id,
				ci.Description AS Description,
				cit.Description AS Type,
				cic.Description AS Category,
				cid.Description AS Detail,
				ci.Amount,
				ci.TaxRate,
				cis.Description AS Status
			FROM dbo.ClaimItem ci
			JOIN dbo.ClaimItemType cit
				ON cit.ClaimItemTypeID = ci.ClaimItemTypeID
			JOIN dbo.ClaimItemCategory cic
				ON cic.ClaimItemCategoryID = ci.ClaimItemCategoryID
			LEFT JOIN dbo.ClaimItemDetail cid
				ON cid.ClaimItemDetailID = ci.ClaimItemDetailID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			WHERE ci.ClaimID = @reimbursementId
        ")]
        List<PLSAReimbursementItemData> GetReimbursementLineItems(int reimbursementId);

        [Sql(@"
			SELECT
				ci.ClaimItemID AS Id,
				ci.Description AS Description,
				cit.Description AS Type,
				cic.Description AS Category,
				cid.Description AS Detail,
				ci.Amount,
				ci.TaxRate,
				cis.Description AS Status
			FROM dbo.ClaimItem ci
			JOIN dbo.ClaimItemType cit
				ON cit.ClaimItemTypeID = ci.ClaimItemTypeID
			JOIN dbo.ClaimItemCategory cic
				ON cic.ClaimItemCategoryID = ci.ClaimItemCategoryID
			LEFT JOIN dbo.ClaimItemDetail cid
				ON cid.ClaimItemDetailID = ci.ClaimItemDetailID
			JOIN dbo.ClaimItemStatus cis
				ON cis.ClaimItemStatusID = ci.ClaimItemStatusID
			WHERE ci.ClaimID = @preAuthId
        ")]
        List<PLSAPreAuthorizationItemData> GetPreAuthorizationLineItems(int preAuthId);

        [Sql(@"
			SELECT pvd.EmailAddress from dbo.Provider pvd
			WHERE pvd.ProviderId = @providerId
        ")]
        string GetProviderEmail(int providerId);

        [Sql(@"
			SELECT TOP 1
				c.ClaimId AS Id,
				c.HouseholdMemberID,
				hhm.PersonID AS StudentId,
				COALESCE(hhm.EmailAddress, parent.EmailAddress) AS Email,
				hhm.FullName AS StudentName,
				pvd.Description AS ProviderName
			FROM dbo.Claim c
			JOIN dbo.HouseholdMember hhm
				ON hhm.HouseholdMemberID = c.HouseholdMemberID
			JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			JOIN dbo.HouseholdMember parent
				ON parent.HouseholdID = hh.HouseholdID
				AND parent.HouseholdMemberTypeID = 1
			JOIN SAPAwards.ECSB1_StudentAccounts sa
				ON sa.StudentID = hhm.PersonID
			JOIN dbo.Provider pvd
				ON pvd.ProviderID = c.ProviderID
			WHERE c.ClaimTypeId = 2
			AND c.ClaimStatusID NOT IN (@statusesWeDontWant)
			AND c.ProviderID IS NOT NULL
			AND EXISTS
			(
				SELECT * FROM
				dbo.ClaimItem ci
				WHERE ci.CLaimId = c.ClaimId
			)
			AND NOT EXISTS
			(
				SELECT * FROM
				dbo.Claim c2
				WHERE c2.PreAuthorizationID = c.ClaimID
			)
			AND sa.CurrentYearFunded > sa.CurrentYearPaid
			ORDER BY NEWID()
        ")]
        PLSAPreAuthorizationData GetPreAuthorizationExcludingStatuses(IEnumerable<int> statusesWeDontWant);

        [Sql(@"
			SELECT TOP 1
				c.ClaimId AS Id,
				c.HouseholdMemberID,
				hhm.PersonID AS StudentId,
				COALESCE(hhm.EmailAddress, parent.EmailAddress) AS Email,
				hhm.FullName AS StudentName,
				pvd.Description AS ProviderName,
				c.DateCreated AS RequestDate
			FROM dbo.Claim c
			JOIN dbo.HouseholdMember hhm
				ON hhm.HouseholdMemberID = c.HouseholdMemberID
			JOIN dbo.Household hh
				ON hh.HouseholdID = hhm.HouseholdID
			JOIN dbo.HouseholdMember parent
				ON parent.HouseholdID = hh.HouseholdID
				AND parent.HouseholdMemberTypeID = 1
			JOIN SAPAwards.ECSB1_StudentAccounts sa
				ON sa.StudentID = hhm.PersonID
			JOIN dbo.Provider pvd
				ON pvd.ProviderID = c.ProviderID
			WHERE c.ClaimTypeId = 2
			AND c.ClaimStatusID = @status
			AND c.ProviderID IS NOT NULL
			AND EXISTS
			(
				SELECT * FROM
				dbo.ClaimItem ci
				WHERE ci.CLaimId = c.ClaimId
			)
			AND NOT EXISTS
			(
				SELECT * FROM
				dbo.Claim c2
				WHERE c2.PreAuthorizationID = c.ClaimID
			)
			AND sa.CurrentYearFunded > sa.CurrentYearPaid
			ORDER BY NEWID()
        ")]
        PLSAPreAuthorizationData GetPreAuthorizationWithSpecificStatus(int status);

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
			SELECT TOP 1 *
            FROM
            (
				SELECT
					pvd.ProviderID AS Id,
					pvd.Description AS Name,
					pvd.TaxID AS TaxId,
					pvd.LicenseNumber,
					pvdt.Description AS LicenseType,
                    pvdt.ProviderPrefix AS LicenseTypeAbbreviation,
					pvd.ExpirationDate AS LicenseExpirationDate,
					pvdas.Description AS ApprovalStatus,
					pvd.ApprovedDate AS ApprovalDate,
					pvd.EmailAddress AS Email,
					pvd.GroupId
				FROM dbo.Provider pvd
				JOIN dbo.ProviderType pvdt
					ON pvdt.ProviderTypeID = pvd.ProviderTypeID
				JOIN dbo.ProviderApprovalStatus pvdas
					ON pvdas.ProviderApprovalStatusID = pvd.ProviderApprovalStatusID
				LEFT JOIN dbo.ProviderAddress pvda
					ON pvda.ProviderID = pvd.ProviderID
				WHERE pvdas.Description = 'Approved'
				AND EXISTS
				(
					SELECT
						P.EmailAddress AS ProviderEmail
					FROM dbo.Provider AS P
						LEFT JOIN dbo.UserProvider AS UP ON UP.ProviderID = P.ProviderID
						LEFT JOIN dbo.UserMap AS UM ON UM.UserID = UP.UserID
						LEFT JOIN dbo.aspnet_Users AS AU ON AU.UserId = UM.UserId_Membership
					WHERE AU.UserId IS NOT NULL
					AND P.ProviderID = pvd.ProviderID
				)
            ) BaseSet
            ORDER BY NEWID()
        ")]
        PLSAProviderData GetUsableProvider();

        [Sql(@"
            SELECT pvdt.Description
            FROM dbo.ProviderType pvdt
            WHERE pvdt.ProviderPrefix = @prefix
        ")]
        string GetProviderLicenseTypeFromPrefix(string prefix);

        [Sql(@"
			DECLARE @claimHHM AS INT

			DECLARE	@ssn AS VARCHAR(MAX)

			SELECT @claimHHM = c.HouseholdMemberId FROM dbo.Claim c
			WHERE c.ClaimId = @reimbursementId

			SELECT @ssn = hhm.SocialSecurityNumber FROM dbo.HouseholdMember hhm
			WHERE hhm.HouseholdMemberID = @claimHHM

			;WITH dupedHHMIDs(HouseholdMemberId) AS
			(
				SELECT hhm2.HouseholdMemberID FROM dbo.HouseholdMember hhm2
				WHERE hhm2.SocialSecurityNumber = @ssn
			),
			dupedPersonIDs(PersonId) AS
			(
				SELECT p.PersonId FROM dbo.Person p
				JOIN dupedHHMIDs ON dupedHHMIDs.HouseholdMemberId = p.RootHouseholdMemberID
			)

				SELECT CAST(CASE WHEN COUNT(*) > 0 THEN 1 ELSE 0 END AS BIT) FROM SAPAwards.ECSB1_StudentAccounts sa
			JOIN dupedPersonIDs ON dupedPersonIDs.PersonId = sa.StudentID
        ")]
        bool IsReimbursementLinkedToFundedStudent(int reimbursementId);

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
    }
}
