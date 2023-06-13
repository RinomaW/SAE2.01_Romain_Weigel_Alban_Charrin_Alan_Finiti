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


        public ObservableCollection<Attribution> LesAttributions { get; set; }
        public ObservableCollection<Categorie> LesCategories { get; set; }
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public ObservableCollection<Personnel> LesPersonnels { get; set; }
        public ApplicationData()    
        {
            LesAttributions = new ObservableCollection<Attribution>();
            LesCategories = new ObservableCollection<Categorie>();
            Attribution e = new Attribution();
            LesAttributions = e.FindAll();
            Categorie c = new Categorie();
            LesCategories = c.FindAll();
        }
    }
}
