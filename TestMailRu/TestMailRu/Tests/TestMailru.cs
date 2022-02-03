using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMailRu.WebObject;





namespace TestMailRu.Tests
{
    [TestClass]
    public class TestMailru : BaseTest
    {
        private string baseUrl = "https://mail.ru/";
        private HomePage homePage;
        private PersonalAccountPage personalAccountPage;

        private string password = "ITNUA71pd";// данные брать из текстового документа
        private string login = "epam.test.kopylov@mail.ru";
        private string textSubject = "Test mail for EPAM";
        private string mailContent = "Lorem Ipsum is simply dummy text of the printing and typesetting " +
                                     "industry. Lorem Ipsum has been the industry's standard dummy text" +
                                     " ever since the 1500s, when an unknown printer took a galley of " +
                                     "type and scrambled it to make a type specimen book. ";
        

        [TestMethod]
        public void TestSavingLetterInDraft()
        {
            homePage = new HomePage();
            homePage.LogInToMailbox(login, password);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.WriteMail(login, textSubject, mailContent);
            personalAccountPage.ExitMail();
        }

        [TestMethod]
        public void TestzDeletedLetterInDraft()
        {
            homePage = new HomePage();
            homePage.LogInToMailbox(login, password);
            personalAccountPage = new PersonalAccountPage();
            personalAccountPage.OpenDraft();
            personalAccountPage.DeleteDraft();
            personalAccountPage.ExitMail();
        }




    }
}
