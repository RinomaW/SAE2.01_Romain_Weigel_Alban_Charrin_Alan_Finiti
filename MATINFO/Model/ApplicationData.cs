using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class ApplicationData
    {
        public ObservableCollection<Attribution> LesAttribution { get; set; }
        public ObservableCollection<Categorie> LesCategorie { get; set; }
        public ApplicationData()    
        {
            Attribution e = new Attribution();
            LesAttribution = e.FindAll();
            Categorie c = new Categorie();
            LesCategorie = c.FindAll();
        }
    }
}
