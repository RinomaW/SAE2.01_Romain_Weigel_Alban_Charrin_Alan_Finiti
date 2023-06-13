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
        public ObservableCollection<Categorie> LesCategories { get; set; }
        public ApplicationData()    
        {
            LesAttribution = new ObservableCollection<Attribution>();
            LesCategories = new ObservableCollection<Categorie>();
            Attribution e = new Attribution();
            LesAttribution = e.FindAll();
            Categorie c = new Categorie();
            LesCategories = c.FindAll();
        }
    }
}
