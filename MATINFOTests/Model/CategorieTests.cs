using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    [TestClass()]
    public class CategorieTests
    {
        [TestInitialize()]
        public void Init()
        {
            Categorie categoriePC = new Categorie("PC");
            Categorie categorieImprimante = new Categorie("Imprimante");
            Personnel ab = new Personnel("a.b@gmail.com", "a" ,"b");
            Personnel ac = new Personnel("b", "c", "b.c@gmail.com");
        }
        [TestMethod()]
        [ExpectedException(null)]
        public void CategorieTestTrue()
        {
            Categorie categoriePC = new Categorie("PC"); 
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CategorieTestTropLong()
        {
            Categorie categorieTropLong = new Categorie("ordinateur quantique ultra fin et portable utilisé a des fins personnelles");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CategorieTestNull()
        {
            Categorie categorienull = new Categorie("");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CategorieTestExisteDeja()
        {
            Categorie categorieexistedeja1 = new Categorie("Imprimante");
            Categorie categorieexistedeja2 = new Categorie("Imprimante");
        }

        [TestMethod()]
        public void CreateTestCategorieTrue()
        {
            Categorie catCreateTrue = new Categorie();
            //Assert.IsTrue(catCreateTrue.Create("PC"));
        }

        [TestMethod()]
        public void CreateTestCategorieFalse()
        {
            Personnel catCreateFalse = new Personnel();
            //Assert.IsFalse(catCreateFalse.Create("a.b@gmail.com", "a", "b"));
        }
        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FindAllTest()
        {
            Assert.Fail();
        }
    }
}