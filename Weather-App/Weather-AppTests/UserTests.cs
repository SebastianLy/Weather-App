using Microsoft.VisualStudio.TestTools.UnitTesting;
using Weather_App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_App.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void encodeSameStringGiveSameEncodedStrings()
        {
            string example1 = "qwjncdS1RfsdFefTRG435^$";
            string example2 = example1;
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsTrue(encodedExample1 == encodedExample2);
        }
        [TestMethod()]
        public void encodeDifferentStringGiveDifferentEncodedStrings()
        {
            string example1 = "qwjncdS1RfsdFefTRG435^$";
            string example2 = "qwjncdS1RfsdFEfTRG435^$";
            string encodedExample1 = User.Encode(example1);
            string encodedExample2 = User.Encode(example2);
            Assert.IsFalse(encodedExample1 == encodedExample2);
        }
    }
}