using NUnit.Framework;

namespace UserRegistration
{
    public class Tests
    {
        Registration registration;
        [SetUp]
        public void Setup()
        {
            registration = new Registration();
        }

        [Test]
        public void ValidFirstName()
        {
            string FirstName = "Rajvardhan";
            string expected = "First Name is valid";

            string actual = registration.checkfirstname(FirstName);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidLastName()
        {
            string LastName = "Singh";
            string expected = "Last Name is valid";

            string actual = registration.checklastname(LastName);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidEmail()
        {
            string Email = "rajvardhan.26@gmail.com";
            string expected = "Email is valid";

            string actual = registration.checkEmail(Email);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidNumber()
        {
            string Mobile = "91 8439560765";
            string expected = "Mobile Number is valid";

            string actual = registration.checkMobile(Mobile);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidPassword()
        {
            string Password = "Hello$12a";
            string expected = "Password is valid";

            string actual = registration.checkPassword(Password);

            Assert.AreEqual(expected, actual);
        }
    }
}