using Microsoft.VisualStudio.TestTools.UnitTesting;
using Password;

namespace Password
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void CheckPassword_ReturnsCorrect_Test1()
        {
            string password = "qwerty1234Q#";
            string expected = "все хорошо";
            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPassword_ReturnsErrorMessage_Test2()
        {
            string password = "abc";
            string expected = "Попробуйте снова";
            string actual = Password.checkPassword(password);
        }
        [TestMethod]
        public void CheckPassword_ReturnsErrorMessage_Test3()
        {
            string password = "qwerty1234";
            string expected = "Попробуйте снова";
            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckPassword_ReturnsErrorMessage_Test4()
        {
            string password = "qwerty1234#";
            string expected = "Попробуйте снова";
            string actual = Password.checkPassword(password);
            Assert.AreEqual(expected, actual);
        }
    }
}