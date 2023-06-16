using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATINFO.Model;

namespace MATINFO.Tests
{
    [TestClass()]
    public class PersonnelTests
    {

        [TestInitialize()]
        public void Init()
        {
            
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "le @ avant le . et pas au début")]
        public void PersonnelTest()
        {
            Personnel jean = new Personnel("email.gmail@com", "jean", "lamoi");
            Personnel peire = new Personnel("email.gmail.com", "peire", "caro");
            Personnel cein = new Personnel("email@gmail@com", "cein", "polo");
            Personnel eve = new Personnel("@gmail.com", "eve", "adam");
        }
    }
}