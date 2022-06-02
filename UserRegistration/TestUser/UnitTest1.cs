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
    }
}