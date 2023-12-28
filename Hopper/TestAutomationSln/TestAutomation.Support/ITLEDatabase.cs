using System;
using System.Collections.Generic;
using TestAutomation.Support;
using Insight.Database;

namespace TestAutomation.Support
{
    public interface ITLEDatabase
    {
        [Sql(@"
			SELECT
				sy.SchoolYearID AS Id,
				sy.Description AS Description
			FROM
				dbo.SchoolYear sy
			WHERE sy.IsActive = 1
        ")]
        SchoolYear GetCurrentSchoolYear();

        [Sql(@"
            SELECT
               lcap.Description,
	           lcap.StartDate,
	           lcap.EndDate,
			   lcap.PeriodNumber AS Number
            FROM dbo.LearningCompactAcademicPeriods lcap
            JOIN dbo.SchoolDetails sd
                ON sd.SchoolDetailId = lcap.SchoolDetailId
            JOIN dbo.schools s
                ON s.schoolid = sd.SchoolId
            WHERE s.doeschoolcode = @schoolCode
            AND sd.SchoolYearId = @schoolYearId
            AND ISNULL(lcap.StartDate, CONVERT(date, getdate())) <= CONVERT(date, getdate())
            AND ISNULL(lcap.EndDate, CONVERT(date, getdate())) >= CONVERT(date, getdate())
        ")]
        TLEGradingPeriod GetCurrentGradingPeriod(int schoolCode, int schoolYearId);

        [Sql(@"
            SELECT TOP 1
               lcap.Description,
	           lcap.StartDate,
	           lcap.EndDate,
			   lcap.PeriodNumber AS Number
            FROM dbo.LearningCompactAcademicPeriods lcap
            JOIN dbo.SchoolDetails sd
                ON sd.SchoolDetailId = lcap.SchoolDetailId
            JOIN dbo.schools s
                ON s.schoolid = sd.SchoolId
            WHERE s.doeschoolcode = @schoolCode
            AND sd.SchoolYearId = @schoolYearId
			AND lcap.PeriodNumber IS NOT NULL
			ORDER BY lcap.PeriodNumber ASC
        ")]
        TLEGradingPeriod GetFirstGradingPeriod(int schoolCode, int schoolYearId);

        [Sql(@"
            SELECT
	            ad.Description,
	            ad.BeginDate,
	            ad.EndDate
            FROM dbo.AssessmentDurations ad
            WHERE ad.SchoolYearId = @schoolYearId
            AND ISNULL(ad.BeginDate, CONVERT(date, getdate())) <= CONVERT(date, getdate())
            AND ISNULL(ad.EndDate, CONVERT(date, getdate())) >= CONVERT(date, getdate())
        ")]
        TLEAssessmentPeriod GetCurrentAssessmentPeriod(int schoolYearId);

        [Sql(@"
            SELECT
	            ad.Description,
	            ad.BeginDate,
	            ad.EndDate
            FROM dbo.AssessmentDurations ad
            WHERE ad.SchoolYearId = @schoolYearId
			AND ad.Description = 'AUG'
        ")]
        TLEAssessmentPeriod GetFirstAssessmentPeriod(int schoolYearId);

        [Sql(@"
			SELECT TOP 1
				LockedGradeBooks.SchoolId
			FROM
			(
				SELECT
					s.SchoolId
				FROM
					dbo.Schools s
				JOIN dbo.Teachers t
					ON t.SchoolId = s.SchoolId
				JOIN dbo.ClassRooms cr
					ON cr.TeacherId = t.TeacherId
				JOIN dbo.UnitPlans up
					ON up.ClassRoomId = cr.ClassRoomId
				JOIN dbo.UserSchools us
					ON us.SchoolId = s.SchoolId
				WHERE up.IsGradeSubmitted = 1
					AND cr.SchoolYearId = @schoolYearId
			) LockedGradeBooks
			ORDER BY NEWID()
        ")]
        int? GetSchoolWithLockedGradebooks(int schoolYearId);

        [Sql(@"
			SELECT aspmem.Email, roles.RoleName FROM dbo.Schools s
			JOIN dbo.UserSchools us
				ON us.SchoolId = s.SchoolId
			JOIN dbo.Users u
				ON u.UserId = us.UserId
			JOIN SUFS_Test.dbo.aspnet_Membership aspmem
				ON aspmem.UserId = u.MembershipUserId
			JOIN SUFS_Test.dbo.aspnet_UsersInRoles uroles
				ON uroles.UserId = u.MembershipUserId
			JOIN SUFS_Test.dbo.aspnet_Roles roles
				ON roles.RoleId = uroles.RoleId
			WHERE s.SchoolId = @schoolId
				AND roles.RoleId = '6A492FEC-AB18-4C0B-BB55-D03A7F506258'
        ")]
        string GetAdminLoginForSchool(int schoolId);

        [Sql(@"
            DECLARE @startDate DateTime
            DECLARE @endDate DateTime
			DECLARE @currentSchoolYearId INT

			SELECT
				@currentSchoolYearId = sy.SchoolYearId
			FROM
				dbo.SchoolYear sy
			WHERE sy.IsActive = 1

            SELECT
	            @startDate = sy.BeginDate
            FROM dbo.SchoolYear sy
            WHERE sy.SchoolYearId = @currentSchoolYearId

            Select @endDate = (@startDate - 1)

			select @endDate = DateAdd(mm, -1, @endDate)

            SELECT
	            sy1.SchoolYearId AS Id,
	            sy1.Description AS Description
            FROM dbo.SchoolYear sy1
            WHERE sy1.EndDate = @endDate
        ")]
        SchoolYear GetPreviousSchoolYear();

        [Sql(@"
			SELECT TOP 1
				TLEClasses.Teacher,
				TLEClasses.Period,
				TLEClasses.Description,
				TLEClasses.TeacherLogin
			FROM
			(
				SELECT
					CONCAT(t.FirstName, ' ', t.LastName) AS Teacher,
					clr.Period AS Period,
					clr.Description,
					clr.ClassRoomId,
					t.Email AS TeacherLogin
				FROM dbo.StudentDetails sd
				JOIN dbo.Enrollments AS enr
					ON enr.StudentDetailId = sd.StudentDetailId
				JOIN dbo.Schools AS sch
					ON sch.SchoolId = sd.SchoolId
				JOIN dbo.ClassRooms AS clr
					ON clr.ClassRoomId = enr.ClassRoomId
				JOIN dbo.Teachers t
					ON t.TeacherId = clr.TeacherId
					AND t.SchoolId = @schoolCode
				WHERE sd.SchoolYearId = @schoolYear
					AND enr.Active = 1
					AND clr.IsActive = 1
					AND sd.IsActive = 1
			) TLEClasses
			ORDER BY NEWID()
        ")]
        TLEClassData GetClassWithStudentsInSchool(int schoolYear, int schoolCode);

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
				FROM dbo.StudentDetails AS sd
				JOIN dbo.Enrollments AS e
					ON e.StudentDetailId = sd.StudentDetailId
				JOIN dbo.Schools AS s
					ON s.SchoolId = sd.SchoolId
				JOIN dbo.ClassRooms AS cr
					ON cr.ClassRoomId = e.ClassRoomId
				JOIN dbo.UserSchools us
					ON us.SchoolId = s.SchoolId
				JOIN dbo.Users u
					ON u.UserId = us.UserId
				JOIN SUFS_Test.dbo.aspnet_Membership aspmem
					ON aspmem.UserId = u.MembershipUserId
				JOIN SUFS_Test.dbo.aspnet_UsersInRoles uroles
					ON uroles.UserId = u.MembershipUserId
				JOIN SUFS_Test.dbo.aspnet_Roles roles
					ON roles.RoleId = uroles.RoleId
					AND roles.RoleId = '6A492FEC-AB18-4C0B-BB55-D03A7F506258'
				WHERE sd.SchoolYearId = @schoolYear
						AND e.Active = 1
						AND sd.IsActive = 1
						AND cr.IsActive = 1
				AND NOT EXISTS
				(
					SELECT * FROM SUFS_Test.dbo.vw_aspnet_UsersInRoles roles2
					WHERE roles2.UserId = uroles.UserId
					and roles2.RoleId = '4A9E888D-B14E-4F7D-A6CC-188AB0E73C1E'
					and roles2.RoleID != '6A492FEC-AB18-4C0B-BB55-D03A7F506258'
				)
				GROUP BY s.Description, s.SchoolId, s.DoeSchoolCode, aspmem.Email
		    ) TLESchools
		    ORDER BY NEWID()
        ")]
        SchoolData GetSchoolWithPopulatedClasses(int schoolYear);
    }
}
