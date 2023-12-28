using System;
using NLPLogix.Core.Abstract;
using NUnit.Framework;

namespace TestSuite
{
    public class Dashboard : Selenium
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
        public void Florida_CreateGuardian()
        {
            GetNLPLogix(FLORIDA).CreateGuardianAccount(ENGLISH).ClickDashboard();
        }

        [TestCase]
        public void Florida_CreateSpanishGuardian()
        {
            GetNLPLogix(FLORIDA).CreateGuardianAccount(SPANISH).ClickDashboard();
        }

        [TestCase]
        public void Florida_AssertHeaders()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getHeader().Equals("Guardian User"));
            SoftAssert.That(Dashboard.getStudentLearningHeader().Equals("Your Student's Learning Plan"));
            SoftAssert.That(Dashboard.getMyApplicationHeader().Equals("My Applications"));
            SoftAssert.That(Dashboard.getMyStudentHeader().Equals("My Students"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsHeader().Equals("Available Scholarships"));
            SoftAssert.That(Dashboard.getFindYourStudentHeader().Equals("Find Your Students"));
            SoftAssert.VerifyAll();

        }

        [TestCase]
        public void Florida_AssertHeadersTranslated()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(SPANISH).ClickDashboard();

            SoftAssert.That(Dashboard.getStudentLearningHeader().Equals("El Plan de Aprendizaje de su Estudiante (SLP)"));
            SoftAssert.That(Dashboard.getMyApplicationHeader().Equals("Mis Solicitudes"));
            SoftAssert.That(Dashboard.getMyStudentHeader().Equals("Mis Estudiantes"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsHeader().Equals("Becas Disponibles"));
            SoftAssert.That(Dashboard.getFindYourStudentHeader().Equals("Busque Sus Estudiantes"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_vAssertLearningPlanText()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getStudentLearningText().Equals("A Student Learning Plan is a plan developed by a parent/guardian to guide instruction for his or her student. Florida state law requires that a Student Learning Plan be completed for a Personalized Education Program (PEP) student, but this tool is available to be used by students in any scholarship program. Your SLP may be used to help identify goods or services that can help address a student's learning priorities. Please note: For PEP students, a Student Learning Plan is required to receive scholarship funds."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertLearningPlanTextTranslated()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(SPANISH).ClickDashboard();

            SoftAssert.That(Dashboard.getStudentLearningText().Equals("Un Plan de Aprendizaje del Estudiante es un plan desarrollado por un padre/guardián para guiar la instrucción de su estudiante. La ley del estado de Florida requiere que se complete un Plan de Aprendizaje del Estudiante para un estudiante del Programa de Educación Personalizada (PEP); sin embargo, esta herramienta está disponible para ser utilizada por estudiantes en cualquier programa de beca. Su SLP (Plan de Aprendizaje del Estudiante) puede usarse para ayudar a identificar bienes o servicios que pueden ayudar a abordar las prioridades de aprendizaje de un estudiante. Por favor nota: Para los estudiantes de PEP, se requiere un Plan de Aprendizaje del Estudiante para recibir fondos de becas."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertAvailableScholarshipText()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsImportantNoticeText().Equals("IMPORTANT NOTICE\r\nYou can only submit one application per program for FES-UA, FTC and FES-EO. Please make sure all students have been added to the My Students section on the left before applying. After you click 'Apply' select all students you want to apply for new and renewing students."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsFTCHeaderText().Equals("Scholarship for Private Schools, Transportation, and Homeschool"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsFTCText().Equals("FTC and FES-EO give families a choice between private school tuition and fees, or transportation costs to attend a public school different than the ones they are assigned to. Parents will also have the option to elect their student(s) as participants in the Personalized Education Program (FTC PEP) which provides educational funds to home educated students. Please keep in mind that a Student Learning Plan will be required to receive funds for FTC PEP."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsUAHeaderText().Equals("Students with Unique Abilities (FES-UA)"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsUAText().Equals("FES-UA allows parents of students with Unique Abilities to direct funds toward a combination of programs and approved providers."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsNewWorldsHeaderText().Equals("New Worlds Scholarship Accounts"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsNewWorldsText().Equals("Is your public school student having trouble with reading or math? If so, the New Worlds Scholarship Accounts program may help."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertAvailableScholarshipTextTranslated()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(SPANISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsImportantNoticeText().Equals("AVISO IMPORTANTE\r\nSolo puede presentar una solicitud por programa para FES-UA, FTC y FES-EO. Por favor asegúrese de haber agregado a todos los estudiantes en la sección Mis Estudiantes a la izquierda antes de presentar su solicitud.  Después de hacer clic en 'Solicitar', seleccione todos los estudiantes que desear solicitar para estudiantes nuevos y renovantes."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsFTCHeaderText().Equals("Beca para escuelas privadas, transporte y educación en el hogar"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsFTCText().Equals("FTC y FES-EO les dan a las familias la opción entre la matrícula y las cuotas de una escuela privada, o los costos de transporte para asistir a una escuela pública diferente a la que se les asignó. Los padres también tendrán la opción de elegir a su(s) estudiante(s) como participantes en el Programa de Educación Personalizada (FTC PEP) que proporciona fondos educativos a los estudiantes educados en el hogar. Por favor tenga en cuenta que se requerirá un Plan de Aprendizaje del Estudiante (Student Learning Plan) para recibir fondos para FTC PEP."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsUAHeaderText().Equals("Estudiantes con Necesidades Especiales (FES-UA)"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsUAText().Equals("FES-UA permite a los padres de estudiantes con necesidades especiales dirigir sus fondos a una combinación de programas y proveedores aprobados."));
            SoftAssert.That(Dashboard.getAvailableScholarshipsNewWorldsHeaderText().Equals("Cuentas de Beca New Worlds"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsNewWorldsText().Equals("¿Su hijo de escuela pública tiene dificultades con la lectura o matemáticas? Si es así, el programa de Cuentas de Beca New Worlds puede ayudar."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertFindYourStudentText()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getFindYourStudentText().Equals("To streamline the renewal application process, we’ll need to import your existing student data into EMA. In the My Students section of your portal, click on the Import Students button to Login and import your student data."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertFindYourStudentTextTranslated()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(SPANISH).ClickDashboard();

            Console.WriteLine(Dashboard.getFindYourStudentText());

            SoftAssert.That(Dashboard.getFindYourStudentText().Equals("Para agilizar el proceso de solicitud de renovación, necesitaremos importar sus datos de estudiante existentes a EMA. En la sección Mis Estudiantes de su portal, haga clic en el botón Importar Estudiantes para iniciar sesión e importar los datos de su estudiante."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertButtonText()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonText().Equals("UPDATE"));
            SoftAssert.That(Dashboard.getFTCButtonText().Equals("APPLY"));
            SoftAssert.That(Dashboard.getUAButtonText().Equals("APPLY"));
            SoftAssert.That(Dashboard.getNewWorldsButtonText().Equals("APPLY"));
            SoftAssert.That(Dashboard.getFindStudentButtonText().Equals("GET STARTED"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertButttonTextTranslated()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(SPANISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonText().Equals("ACTUALIZAR"));
            SoftAssert.That(Dashboard.getFTCButtonText().Equals("SOLICITAR"));
            SoftAssert.That(Dashboard.getUAButtonText().Equals("SOLICITAR"));
            SoftAssert.That(Dashboard.getNewWorldsButtonText().Equals("SOLICITAR"));
            SoftAssert.That(Dashboard.getFindStudentButtonText().Equals("EMPEZAR"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void Florida_AssertButtonColor()
        {
            var Dashboard = GetNLPLogix(FLORIDA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getFTCButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getFTCButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getUAButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getUAButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getNewWorldsButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getNewWorldsButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getFindStudentButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getFindStudentButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.VerifyAll();
        }

        //======================================================================================================
        // Test Methods - West Virgina
        //======================================================================================================

        [TestCase]
        public void WestVirgina_CreateGuardian()
        {
            GetNLPLogix(WESTVIRGINA).CreateGuardianAccount(ENGLISH).ClickDashboard();
        }

        [TestCase]
        public void WestVirgina_AssertHeaders()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getHeader().Equals("Guardian User"));
            SoftAssert.That(Dashboard.getStudentLearningHeader().Equals("Your Student's Learning Plan"));
            SoftAssert.That(Dashboard.getMyApplicationHeader().Equals("My Applications"));
            SoftAssert.That(Dashboard.getMyStudentHeader().Equals("My Students"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsHeader().Equals("Available Scholarships"));
            SoftAssert.That(Dashboard.getFindYourStudentHeader().Equals("Find Your Students"));
            SoftAssert.VerifyAll();

        }

        [TestCase]
        public void WestVirgina_AssertLearningPlanText()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getStudentLearningText().Equals("A Student Learning Plan is a plan developed by a parent/guardian to guide instruction for his or her student. Florida state law requires that a Student Learning Plan be completed for a Personalized Education Program (PEP) student, but this tool is available to be used by students in any scholarship program. Your SLP may be used to help identify goods or services that can help address a student's learning priorities. Please note: For PEP students, a Student Learning Plan is required to receive scholarship funds."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_AssertAvailableScholarshipText()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsHOPEHeaderText().Equals("Hope Scholarship"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsHOPEText().Equals("Are you interested in applying for the West Virginia Hope Scholarship Program, our education savings account (ESA) program, to tailor an individualized learning experience for your child? If so, apply now."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_AssertAvailableScholarshipDoNotExist()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.doesUAApplicationExist().Equals(false));
            SoftAssert.That(Dashboard.doesAvailableScholarshipsNewWorldsExist().Equals(false));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_AssertFindYourStudentText()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getFindYourStudentText().Equals("To streamline the renewal application process, we’ll need to import your existing student data into EMA. In the My Students section of your portal, click on the Import Students button to Login and import your student data."));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_AssertButtonText()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonText().Equals("UPDATE"));
            SoftAssert.That(Dashboard.getHOPEButtonText().Equals("APPLY"));
            SoftAssert.That(Dashboard.getFindStudentButtonText().Equals("GET STARTED"));
            SoftAssert.VerifyAll();
        }

        [TestCase]
        public void WestVirgina_AssertButtonColor()
        {
            var Dashboard = GetNLPLogix(WESTVIRGINA).LoginWithPrimaryGuardianAccount(ENGLISH).ClickDashboard();

            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getAvailableScholarshipsButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getHOPEButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getHOPEButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.That(Dashboard.getFindStudentButtonForegroundColor().Equals("rgba(255, 255, 255, 1)"));
            SoftAssert.That(Dashboard.getFindStudentButtonBackgroundColor().Equals("rgba(255, 8, 67, 1)"));
            SoftAssert.VerifyAll();
        }
    }

}
