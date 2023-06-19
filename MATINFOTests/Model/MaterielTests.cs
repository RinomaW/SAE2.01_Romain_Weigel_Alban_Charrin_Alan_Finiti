using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model.Tests
{
    [TestClass()]
    public class MaterielTests
    {
        [TestInitialize()]
        public void Init()
        {

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Code barre non unique")]
        public void PersonnelTestCodeBarreUnique()
        {
            Materiel m1 = new Materiel("XXFGXXURXG123IUEHI53WAOUHSE52XES523EXE","MCKANAR","AE-6AYHEIDB",3);
            Materiel m2 = new Materiel("XXFGXXURXG123IUEHI53WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "pas de numéro ou de caractère spéciaux (~#-_) dans le code barre")]
        public void PersonnelTestCodeBarreCaracSpe()
        {
            Materiel m1 = new Materiel("XXFGXXURXG123IUEHI5((((3WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m2 = new Materiel("XXFGXXURXG123IUEHI53~~~~~~WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m3 = new Materiel("XXFGXXURXG123IUEHI53######WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m4 = new Materiel("XXFGXXURXG123IUEHI53------WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m5 = new Materiel("XXFGXXURXG123IUEHI53______WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m6 = new Materiel("XXFGXXURXG123IUEHI53{{{{{WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m7 = new Materiel("XXFGXXURXG123IUEHI53[[[[[WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m8 = new Materiel("XXFGXXURXG123IUEHI53||||WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m9 = new Materiel("XXFGXXURXG123IUEHI53)))))))WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m10 = new Materiel("XXFGXXURXG123IUEHI5]]]]]]3WAOUHSE52XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
            Materiel m11 = new Materiel("XXFGXXURXG123IUEHI53WAOUHSE5}}}}}}}2XES523EXE", "MCKANAR", "AE-6AYHEIDB", 3);
        }

       
    }
}