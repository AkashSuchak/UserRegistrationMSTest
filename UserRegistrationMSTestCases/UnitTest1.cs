using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationMSTest;

namespace UserRegistrationMSTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]  
        [DataRow("Akash")]        
        public void GivenFirstName_CheckIfValid(string name)
        {
            //Arrange
            Validation validation = new Validation();            

            //Act
            bool result = validation.FirstAndLastName(name);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("akash")]
        public void GivenFirstName_CheckIfNotValid(string name)
        {
            //Arrange
            Validation validation = new Validation();

            //Act
            bool result = validation.FirstAndLastName(name);

            //Assert
            Assert.IsFalse(result);
        }
    }
}
