using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MATINFO.Model;

namespace MATINFOTests.Model
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
        public void PersonnelTestGmail()
        {
            Personnel jean = new Personnel("email.gmail@com", "jean", "lamoi");
            Personnel peire = new Personnel("email.gmail.com", "peire", "caro");
            Personnel cein = new Personnel("email@gmail@com", "cein", "polo");
            Personnel eve = new Personnel("@gmail.com", "eve", "adam");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "pas de numéro ou de caractère spéciaux (~#-_)")]
        public void PersonnelTestPrenom()
        {
            Personnel jean = new Personnel("test@gmail.com", "²", "lamoi");
            Personnel peire = new Personnel("test@gmail.com", "&", "caro");
            Personnel cein = new Personnel("test@gmail.com", "\"", "polo");
            Personnel eve = new Personnel("test@gmail.com", "'", "adam");
            Personnel p1 = new Personnel("test@gmail.com", "(", "adam");
            Personnel p2 = new Personnel("test@gmail.com", "-", "adam");
            Personnel p3 = new Personnel("test@gmail.com", "_", "adam");
            Personnel p4 = new Personnel("test@gmail.com", ")", "adam");
            Personnel p5 = new Personnel("test@gmail.com", "=", "adam");
            Personnel p6 = new Personnel("test@gmail.com", "~", "adam");
            Personnel p7 = new Personnel("test@gmail.com", "#", "adam");
            Personnel p8 = new Personnel("test@gmail.com", "{", "adam");
            Personnel p9 = new Personnel("test@gmail.com", "[", "adam");
            Personnel p10 = new Personnel("test@gmail.com", "|", "adam");
            Personnel p11 = new Personnel("test@gmail.com", "`", "adam");
            Personnel p12 = new Personnel("test@gmail.com", "\\", "adam");
            Personnel p13 = new Personnel("test@gmail.com", "^", "adam");
            Personnel p14 = new Personnel("test@gmail.com", "@", "adam");
            Personnel p15 = new Personnel("test@gmail.com", "]", "adam");
            Personnel p16 = new Personnel("test@gmail.com", "}", "adam");
            Personnel p17 = new Personnel("test@gmail.com", "+", "adam");
            Personnel p18 = new Personnel("test@gmail.com", ",", "adam");
            Personnel p19 = new Personnel("test@gmail.com", ";", "adam");
            Personnel p20 = new Personnel("test@gmail.com", ":", "adam");
            Personnel p21 = new Personnel("test@gmail.com", "!", "adam");
            Personnel p22 = new Personnel("test@gmail.com", "ù", "adam");
            Personnel p23 = new Personnel("test@gmail.com", "$", "adam");
            Personnel p24 = new Personnel("test@gmail.com", "*", "adam");
            Personnel p25 = new Personnel("test@gmail.com", "µ", "adam");
            Personnel p26 = new Personnel("test@gmail.com", "£", "adam");
            Personnel p27 = new Personnel("test@gmail.com", "¤", "adam");
            Personnel p28 = new Personnel("test@gmail.com", "¨", "adam");
            Personnel p29 = new Personnel("test@gmail.com", "%", "adam");
            Personnel p30 = new Personnel("test@gmail.com", "§", "adam");
            Personnel p31 = new Personnel("test@gmail.com", "/", "adam");
            Personnel p32 = new Personnel("test@gmail.com", "'", "adam");
            Personnel p33 = new Personnel("test@gmail.com", ".", "adam");
            Personnel p34 = new Personnel("test@gmail.com", "?", "adam");
            Personnel p35 = new Personnel("test@gmail.com", "€", "adam");
            Personnel p36 = new Personnel("test@gmail.com", "", "adam");
            Personnel p37 = new Personnel("test@gmail.com", " ", "adam");
            Personnel p38 = new Personnel("test@gmail.com", "1", "adam");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "le @ avant le . et pas au début")]
        public void PersonnelTestNom()
        {
            Personnel jean = new Personnel("test@gmail.com", "prenom", "²");
            Personnel peire = new Personnel("test@gmail.com", "prenom", "&");
            Personnel cein = new Personnel("test@gmail.com", "prenom", "\"");
            Personnel eve = new Personnel("test@gmail.com", "prenom", "'");
            Personnel p1 = new Personnel("test@gmail.com", "prenom", "(");
            Personnel p2 = new Personnel("test@gmail.com", "prenom", "-");
            Personnel p3 = new Personnel("test@gmail.com", "prenom", "_");
            Personnel p4 = new Personnel("test@gmail.com", "prenom", ")");
            Personnel p5 = new Personnel("test@gmail.com", "prenom", "=");
            Personnel p6 = new Personnel("test@gmail.com", "prenom", "~");
            Personnel p7 = new Personnel("test@gmail.com", "prenom", "#");
            Personnel p8 = new Personnel("test@gmail.com", "prenom", "{");
            Personnel p9 = new Personnel("test@gmail.com", "prenom", "[");
            Personnel p10 = new Personnel("test@gmail.com", "prenom", "|");
            Personnel p11 = new Personnel("test@gmail.com", "prenom", "`");
            Personnel p12 = new Personnel("test@gmail.com", "prenom", "\\");
            Personnel p13 = new Personnel("test@gmail.com", "prenom", "^");
            Personnel p14 = new Personnel("test@gmail.com", "prenom", "@");
            Personnel p15 = new Personnel("test@gmail.com", "prenom", "]");
            Personnel p16 = new Personnel("test@gmail.com", "prenom", "}");
            Personnel p17 = new Personnel("test@gmail.com", "prenom", "+");
            Personnel p18 = new Personnel("test@gmail.com", "prenom", ",");
            Personnel p19 = new Personnel("test@gmail.com", "prenom", ";");
            Personnel p20 = new Personnel("test@gmail.com", "prenom", ":");
            Personnel p21 = new Personnel("test@gmail.com", "prenom", "!");
            Personnel p22 = new Personnel("test@gmail.com", "prenom", "ù");
            Personnel p23 = new Personnel("test@gmail.com", "prenom", "$");
            Personnel p24 = new Personnel("test@gmail.com", "prenom", "*");
            Personnel p25 = new Personnel("test@gmail.com", "prenom", "µ");
            Personnel p26 = new Personnel("test@gmail.com", "prenom", "£");
            Personnel p27 = new Personnel("test@gmail.com", "prenom", "¤");
            Personnel p28 = new Personnel("test@gmail.com", "prenom", "¨");
            Personnel p29 = new Personnel("test@gmail.com", "prenom", "%");
            Personnel p30 = new Personnel("test@gmail.com", "prenom", "§");
            Personnel p31 = new Personnel("test@gmail.com", "prenom", "/");
            Personnel p32 = new Personnel("test@gmail.com", "prenom", "'");
            Personnel p33 = new Personnel("test@gmail.com", "prenom", ".");
            Personnel p34 = new Personnel("test@gmail.com", "prenom", "?");
            Personnel p35 = new Personnel("test@gmail.com", "prenom", "€");
            Personnel p36 = new Personnel("test@gmail.com", "prenom", " ");
            Personnel p37 = new Personnel("test@gmail.com", "prenom", "");
            Personnel p38 = new Personnel("test@gmail.com", "prenom", "1");
        }
    }
}