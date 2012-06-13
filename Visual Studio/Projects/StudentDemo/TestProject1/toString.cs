using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using safeprojectname;

namespace TestProject1
{
    [TestClass]
    public class toString
    {

        Person p = new Person("Darragh", 33);

        [TestMethod]
        public void TestSetAgeWorks()
        {
            p.setAge(10);
            Assert.AreEqual(10, p.getAge());

            //String aTestString = p.makeUpName();
            //Assert.AreEqual("Name is Darragh", aTestString);
        }
    }
}
