-- Original file can be found at Quality Assurance\SQL Queries - Gardiner\PLSA Available funds - info from Epicor.sql

with percon (StudentID_c, Name, EMailAddress, Program_c)
AS
(
SELECT
StudentID_c,
Name,
EMailAddress,
Program_c
FROM dbo.PerCon
)

SELECT Top 50
t2.StudentID,
t1.Name,
t1.EMailAddress,
t2.AvailableBalance
FROM percon t1
CROSS APPLY sufs.GetStudentBalance(t1.StudentID_c , @GLControlCode) AS t2 
WHERE t1.Program_c = @ProgramCode 
AND t2.AvailableBalance  <> 0
AND (@StudentId IS NULL OR @StudentId = @StudentID)