using System;
using API;
using NLPLogix.Core.Abstract;
using NLPLogix.Core.Interface;
using NUnit.Framework;

namespace TestSuite
{
    public class MyStudents : Selenium
    {

        //======================================================================================================
        // Variable
        //======================================================================================================
        public string ENGLISH = "English";
        public string SPANISH = "Spanish";
        public string FLORIDA = "Florida";
        public string WESTVIRGINA = "West Virgina";
        SoftAssertion.SoftAssert SoftAssert = new SoftAssertion.SoftAssert();

        //======================================================================================================
        // Test Methods - Florida
        //======================================================================================================

        [TestCase]
        [Order (1)]
        public void Florida_CanNavigateToMyStudents()
        {
            GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
        }

        [TestCase]
        public void Florida_CreateStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void Florida_CreateStudentWithSpecialCharacters()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void Florida_CreateMultipleStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void Florida_CreateFindableStudents()
        {
            var dashboard = GetNLPLogix(FLORIDA).LoginWith("guardian@scholarfltest.onmicrosoft.com", "$cholar123").ClickMyStudents();
            dashboard.ClickFindStudent().ClickFindStudents().ClickProgram("UA")
                .ClearEmail().TypeEmail("guardian@scholarfltest.onmicrosoft.com")
                .ClearPassword().TypePassword("$cholar123")
                .ClickVerify();
        }

        [TestCase]
        public void Florida_FindStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.ClickFindStudent().ClickFindStudents().ClickApplicationType("UA")
                .ClearEmail().TypeEmail(APIEmailGenerator.EMAIL)
                .ClearPassword().TypeEmail(Credentials.PASSWORD)
                .ClickVerify();

            Assert.That(dashboard.GetAlert().Equals("Error Not Visable"));
        }

        [TestCase]
        public void Florida_FindStudentButtons()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.ApplyForScholarshipsText().Equals("APPLY FOR SCHOLARSHIPS"));
            SoftAssert.That(dashboard.FindStudentText().Equals("FIND STUDENTS"));
            SoftAssert.That(dashboard.AddAStudentText().Equals("ADD A STUDENT"));
            SoftAssert.That(dashboard.ApplyForScholarshipsTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.FindStudentTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.AddAStudentTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.ApplyForScholarshipsBackgroundColor().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.That(dashboard.FindStudentBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(dashboard.AddAStudentBackgroundColor().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentPageHeader()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            Assert.That(dashboard.GetHeaderText().Equals("My Students"));
        }

        [TestCase]
        public void Florida_vMyStudentWelcome()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            Assert.That(dashboard.GetWelcomeMessageText().Equals("If you have a RENEWAL student (child currently receiving scholarship funding), please use the 'FIND STUDENTS' button to connect your renewal student to your EMA account. Renewal students should not be added as a new student. Adding currently funded students as new students will delay your funding.\r\nIf you have a NEW student, please click the 'ADD A STUDENT' button."));
        }

        [TestCase]
        public void Florida_MyStudentActiveStudentText()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentActiveStudentText().Equals("Below, you will find a list of your active students. Please make sure that the information for each student is accurate and up-to-date. Keeping this information current will help streamline the process when applying for scholarships. Only active students can be added to an application and considered for funding."));
        }

        [TestCase]
        public void Florida_MyStudentInactiveStudentText()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentInactiveStudentText().Equals("Below, you will find a list of your inactive students. If you need to add one of these students to your applications you will need to click on the green plus button, to make them an active student. Each student is only allowed on one EMA account. If you are not applying for a student or they do not reside with you, you do not need to do anything, please leave them as inactive."));
        }

        [TestCase]
        public void Florida_MyStudentTableHeader()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            SoftAssert.That(dashboard.GetMyStudentTableTitleText(1).Equals("Active Students"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 1).Equals("STUDENT ID"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 2).Equals("STUDENT NAME"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 3).Equals("DATE OF BIRTH"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 4).Equals(""));
            SoftAssert.That(dashboard.GetMyStudentTableTitleText(2).Equals("Inactive Students"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(4, 1, 1).Equals("STUDENT ID"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 2).Equals("STUDENT NAME"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 3).Equals("DATE OF BIRTH"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 4).Equals(""));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentActiveStudentTableContent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 2).Equals(dashboard.FirstName + " " + dashboard.MiddleName + " " + dashboard.LastName));
            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 4).Equals("View"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentViewStudentHeader()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            Assert.That(dashboard.GetHeaderText().Equals("Student Details"));
        }

        [TestCase]
        public void Florida_MyStudentViewStudentID()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            string ApplicationID = dashboard.GetMyStudentTableContentText(1, 1, 1);

            dashboard.ClickMyStudentView(1, 1);

            Assert.That(dashboard.GetApplicationID().Equals("Student ID: " + ApplicationID));
        }

        [TestCase]
        public void Florida_MyStudentViewStudentEditButton()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent() ;
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.EditStudentButtonText().Equals("EDIT"));
            SoftAssert.That(dashboard.EditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.EditStudentButtonBackgroundColour().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentViewStudentButton()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton();

            SoftAssert.That(dashboard.SaveEditStudentButtonText().Equals("SAVE"));
            SoftAssert.That(dashboard.SaveEditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.SaveEditStudentButtonBackgroundColour().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.That(dashboard.CancelEditStudentButtonText().Equals("CANCEL"));
            SoftAssert.That(dashboard.CancelEditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.CancelEditStudentButtonBackgroundColour().Equals("rgba(39, 48, 67, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_vMyStudentViewStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.GetSuffix().Contains(dashboard.Suffix));
            SoftAssert.That(dashboard.GetGender().Contains(dashboard.Gender));
            SoftAssert.That(dashboard.GetEthnicity().Contains(dashboard.Ethnicity));
            SoftAssert.That(dashboard.GetRelationshipToYou().Contains(dashboard.RelationshipToYou));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentDisabledFields()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(true));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(true));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(true));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(true));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentEditStudent()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton()
                .SelectGender("Male")
                .ClickSave();

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(true));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(true));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(true));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGender().Equals("Male"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentEditStudentDisabledFields()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton();

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(false));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(false));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(false));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(false));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(false));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_FindStudentButtonsTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.ApplyForScholarshipsText().Equals("SOLICITAR PARA BECAS"));
            SoftAssert.That(dashboard.FindStudentText().Equals("BUSQUE ESTUDIANTES"));
            SoftAssert.That(dashboard.AddAStudentText().Equals("AGREGAR UN ESTUDIANTE"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentPageHeaderTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();

            Assert.That(dashboard.GetHeaderText().Equals("Mis Estudiantes"));
        }

        [TestCase]
        public void Florida_MyStudentWelcomeTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();

            Assert.That(dashboard.GetWelcomeMessageText().Equals("Si tiene un estudiante de RENOVACIÓN (un estudiante que actualmente recibe fondos de becas), por favor use el botón 'BUSQUE ESTUDIANTES' para conectar su estudiante de renovación a su cuenta de EMA. Los estudiantes de renovación no deben agregarse como estudiantes nuevos. Agregar estudiantes actualmente financiados como estudiantes nuevos retrasará su financiación.\r\nSi tiene un estudiante NUEVO, por favor haga clic en el botón 'AGREGAR UN ESTUDIANTE.'"));
        }

        [TestCase]
        public void Florida_MyStudentActiveStudentTextTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentActiveStudentText().Equals("A continuación, encontrará una lista de sus estudiantes activos. Por favor asegúrese de que la información de cada estudiante sea precisa y esté actualizada. Mantener esta información actualizada ayudará a simplificar el proceso cuando solicita una beca. Solo los estudiantes activos pueden agregarse a una solicitud y ser considerados para la financiación."));
        }

        [TestCase]
        public void Florida_MyStudentInactiveStudentTextTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentInactiveStudentText().Equals("A continuación, encontrará una lista de sus estudiantes inactivos. Si necesita agregar uno de estos estudiantes a sus aplicaciones, deberá hacer clic en el botón verde para convertirlo en un estudiante activo. Cada estudiante solo puede tener una cuenta EMA. Si no está solicitando un estudiante o no vive con usted, no necesita hacer nada, por favor déjelo como inactivo."));
        }

        [TestCase]
        public void Florida_MyStudentTableHeaderTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();

            SoftAssert.That(dashboard.GetMyStudentTableTitleText(1).Equals("Estudiantes Activos"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 1).Equals("ID DEL ESTUDIANTE"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 2).Equals("NOMBRE DEL ESTUDIANTE"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 3).Equals("FECHA DE NACIMIENTO"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 4).Equals(""));
            SoftAssert.That(dashboard.GetMyStudentTableTitleText(2).Equals("Estudiantes Inactivos"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(4, 1, 1).Equals("ID DEL ESTUDIANTE"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 2).Equals("NOMBRE DEL ESTUDIANTE"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 3).Equals("FECHA DE NACIMIENTO"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 4).Equals(""));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentActiveStudentTableContentTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 2).Equals(dashboard.FirstName + " " + dashboard.MiddleName + " " + dashboard.LastName));
            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 4).Equals("VER"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentViewStudentHeaderTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            Assert.That(dashboard.GetHeaderText().Equals("DETALLES DEL ESTUDIANTE"));
        }

        [TestCase]
        public void Florida_MyStudentViewStudentEditButtonTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.EditStudentButtonText().Equals("EDITAR"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentViewStudentTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.GetSuffix().Contains(dashboard.Suffix));
            SoftAssert.That(dashboard.GetGender().Contains(dashboard.Gender));
            SoftAssert.That(dashboard.GetEthnicity().Contains(dashboard.Ethnicity));
            SoftAssert.That(dashboard.GetRelationshipToYou().Contains(dashboard.RelationshipToYou));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_MyStudentViewStudentButtonTranslated()
        {
            var dashboard = GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton();

            SoftAssert.That(dashboard.SaveEditStudentButtonText().Equals("GUARDAR"));
            SoftAssert.That(dashboard.CancelEditStudentButtonText().Equals("CANCELAR"));
            SoftAssert.VerifyAll();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        [Order(1)]
        public void WestVirgina_CanNavigateToMyStudents()
        {
            GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
        }

        [TestCase]
        public void WestVirgina_CreateStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void WestVirgina_CreateStudentWithSpecialCharacters()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void WestVirgina_CreateMultipleStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
            dashboard.CreateStudent();
        }

        [TestCase]
        public void WestVirgina_CreateFindableStudents()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).LoginWith("guardian@scholarfltest.onmicrosoft.com", "$cholar123").ClickMyStudents();
            dashboard.ClickFindStudent().ClickFindStudents().ClickProgram("UA")
                .ClearEmail().TypeEmail("guardian@scholarfltest.onmicrosoft.com")
                .ClearPassword().TypePassword("$cholar123")
                .ClickVerify();
        }

        [TestCase]
        public void WestVirgina_FindStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.ClickFindStudent().ClickFindStudents().ClickApplicationType("UA")
                .ClearEmail().TypeEmail(APIEmailGenerator.EMAIL)
                .ClearPassword().TypeEmail(Credentials.PASSWORD)
                .ClickVerify();

            Assert.That(dashboard.GetAlert().Equals("Error Not Visable"));
        }

        [TestCase]
        public void WestVirgina_FindStudentButtons()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.ApplyForScholarshipsText().Equals("APPLY FOR SCHOLARSHIPS"));
            SoftAssert.That(dashboard.FindStudentText().Equals("FIND STUDENTS"));
            SoftAssert.That(dashboard.AddAStudentText().Equals("ADD A STUDENT"));
            SoftAssert.That(dashboard.ApplyForScholarshipsTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.FindStudentTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.AddAStudentTextColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.ApplyForScholarshipsBackgroundColor().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.That(dashboard.FindStudentBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(dashboard.AddAStudentBackgroundColor().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentPageHeader()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            Assert.That(dashboard.GetHeaderText().Equals("My Students"));
        }

        [TestCase]
        public void WestVirgina_MyStudentWelcome()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            Assert.That(dashboard.GetWelcomeMessageText().Equals("If you have a RENEWAL student (child currently receiving scholarship funding), please use the 'FIND STUDENTS' button to connect your renewal student to your EMA account. Renewal students should not be added as a new student. Adding currently funded students as new students will delay your funding.\r\nIf you have a NEW student, please click the 'ADD A STUDENT' button."));
        }

        [TestCase]
        public void WestVirgina_MyStudentActiveStudentText()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentActiveStudentText().Equals("Below, you will find a list of your active students. Please make sure that the information for each student is accurate and up-to-date. Keeping this information current will help streamline the process when applying for scholarships. Only active students can be added to an application and considered for funding."));
        }

        [TestCase]
        public void WestVirgina_MyStudentInactiveStudentText()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            Assert.That(dashboard.GetMyStudentInactiveStudentText().Equals("Below, you will find a list of your inactive students. If you need to add one of these students to your applications you will need to click on the green plus button, to make them an active student. Each student is only allowed on one EMA account. If you are not applying for a student or they do not reside with you, you do not need to do anything, please leave them as inactive."));
        }

        [TestCase]
        public void WestVirgina_MyStudentTableHeader()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();

            SoftAssert.That(dashboard.GetMyStudentTableTitleText(1).Equals("Active Students"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 1).Equals("STUDENT ID"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 2).Equals("STUDENT NAME"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 3).Equals("DATE OF BIRTH"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(1, 1, 4).Equals(""));
            SoftAssert.That(dashboard.GetMyStudentTableTitleText(2).Equals("Inactive Students"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(4, 1, 1).Equals("STUDENT ID"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 2).Equals("STUDENT NAME"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 3).Equals("DATE OF BIRTH"));
            SoftAssert.That(dashboard.GetMyStudentTableHeaderText(2, 1, 4).Equals(""));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentActiveStudentTableContent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();

            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 2).Equals(dashboard.FirstName + " " + dashboard.MiddleName + " " + dashboard.LastName));
            SoftAssert.That(dashboard.GetMyStudentTableContentText(1, 1, 4).Equals("View"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentViewStudentHeader()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            Assert.That(dashboard.GetHeaderText().Equals("Student Details"));
        }

        [TestCase]
        public void WestVirgina_MyStudentViewStudentID()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            string ApplicationID = dashboard.GetMyStudentTableContentText(1, 1, 1);

            dashboard.ClickMyStudentView(1, 1);

            Assert.That(dashboard.GetApplicationID().Equals("Student ID: " + ApplicationID));
        }

        [TestCase]
        public void WestVirgina_MyStudentViewStudentEditButton()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.EditStudentButtonText().Equals("EDIT"));
            SoftAssert.That(dashboard.EditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.EditStudentButtonBackgroundColour().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentViewStudentButton()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton();

            SoftAssert.That(dashboard.SaveEditStudentButtonText().Equals("SAVE"));
            SoftAssert.That(dashboard.SaveEditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.SaveEditStudentButtonBackgroundColour().Equals("rgba(26, 66, 138, 1)"));
            SoftAssert.That(dashboard.CancelEditStudentButtonText().Equals("CANCEL"));
            SoftAssert.That(dashboard.CancelEditStudentButtonColour().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(dashboard.CancelEditStudentButtonBackgroundColour().Equals("rgba(39, 48, 67, 1)"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentViewStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.GetSuffix().Contains(dashboard.Suffix));
            SoftAssert.That(dashboard.GetGender().Contains(dashboard.Gender));
            SoftAssert.That(dashboard.GetEthnicity().Contains(dashboard.Ethnicity));
            SoftAssert.That(dashboard.GetRelationshipToYou().Contains(dashboard.RelationshipToYou));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentDisabledFields()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1);

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(true));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(true));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(true));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(true));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentEditStudent()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton()
                .SelectGender("Male")
                .ClickSave();

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(true));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(true));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(true));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(true));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(true));
            SoftAssert.That(dashboard.GetGender().Equals("Male"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_MyStudentEditStudentDisabledFields()
        {
            var dashboard = GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickMyStudents();
            dashboard.CreateStudent();
            dashboard.ClickMyStudentView(1, 1).ClickEditStudentButton();

            SoftAssert.That(dashboard.FirstNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetMiddleNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetLastNameDisabled().Equals(false));
            SoftAssert.That(dashboard.GetSuffixDisabled().Equals(false));
            SoftAssert.That(dashboard.GetFleidNumberDisabled().Equals(false));
            SoftAssert.That(dashboard.GetGenderDisabled().Equals(false));
            SoftAssert.That(dashboard.GetEthnicityDisabled().Equals(false));
            SoftAssert.That(dashboard.GetRelationshipToYouDisabled().Equals(false));
            SoftAssert.VerifyAll();
        }

    }
}