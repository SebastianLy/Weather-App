using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Weather_App.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void encodeSameStringsGiveSameEncodedStrings()
        {
            string example1 = "qwjncdS1RfsdFefTRG435^$";
            string example2 = "qwjncdS1RfsdFefTRG435^$";
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsTrue(encodedExample1 == encodedExample2);
        }
        [TestMethod()]
        public void encodeDifferentStringsGiveDifferentEncodedStrings()
        {
            string example1 = "qwjncdS1RfsdFefTRG435^$";
            string example2 = "qwjncdS1RfsdFEfTRG435^$";
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsFalse(encodedExample1 == encodedExample2);
        }
        [TestMethod()]
        public void encodeEmptyStringsGiveSameEncodedStrings()
        {
            string example1 = "";
            string example2 = "";
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsTrue(encodedExample1 == encodedExample2);
        }
        [TestMethod()]
        public void encodeEmptyStringAndDifferentStringGiveDifferentEncodedStrings()
        {
            string example1 = "";
            string example2 = "fczs234";
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsFalse(encodedExample1 == encodedExample2);
        }
    }
}