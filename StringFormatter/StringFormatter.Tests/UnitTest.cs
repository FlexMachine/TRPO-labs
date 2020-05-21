using StringFormatter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringFormatter.Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            //string str = "flexmachine";
           // string expected = "http://flexmachine";
            //string str1 = "flexmachine.git";
            //string expected1 = "git://flexmachine";
            //var str2 = "";
            //string expected2 = "NullReferencesExeption";
            //act
            //StringFormatter sf = new StringFormatter();
             //string actual = sf.WebString(str);
           // string actual1 = sf.GitString(str1);
            //string actual2 = sf.IsNull(str2);
            //assert
            //Assert.AreEqual(expected, actual);
            //Assert.AreEqual(expected1, actual1);
            //Assert.AreEqual(expected2, actual2);

        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestMethod2()
        {
            string str2 = null;
            
            StringFormatter sf = new StringFormatter();
            string actual2 = sf.IsNull(str2);
        }
    }
}
