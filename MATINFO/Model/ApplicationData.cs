﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class ApplicationData
    {


        public ObservableCollection<Attribution> LesAttributions { get; set; }
        
        public ObservableCollection<Categorie> LesCategories { get; set; }
        public ObservableCollection<Materiel> LesMateriels { get; set; }
        public ObservableCollection<Personnel> LesPersonnels { get; set; }
        public ObservableCollection<Materiel> LesMaterielsDeCategorie { get; set; }
        public ApplicationData()    
        {
            LesAttributions = new ObservableCollection<Attribution>();
            LesCategories = new ObservableCollection<Categorie>();
            LesMateriels= new ObservableCollection<Materiel>();
            LesPersonnels= new ObservableCollection<Personnel>();
            Attribution e = new Attribution();
            LesAttributions = e.FindAll();
            Categorie c = new Categorie();
            LesCategories = c.FindAll();
            Materiel m = new Materiel();
            LesMateriels = m.FindAll();
            Personnel p = new Personnel();
            LesPersonnels = p.FindAll();
            LesCategories.Add(new Categorie("zboub",1));
            LesMateriels.Add(new Materiel("FEZJGVSD15", "PC numéro 92", "DSFHKFHDFB", 1, 1));
            Personnel cedric = new Personnel("cedric.diggory@gmail.com", "diggory", "cedric",1);
            LesPersonnels.Add(cedric);
            LesAttributions.Add(new Attribution("cedric aime les zboubs", DateTime.Today, 1, 1));
            foreach (Materiel unMat in LesMateriels.ToList())
            {
                unMat.UneCategorie = LesCategories.ToList().Find(g => g.ID_Categorie == unMat.IdCategorie);
            }
            foreach (Categorie uneCategorie in LesCategories.ToList())
            {
                uneCategorie.LesMateriels = new ObservableCollection<Materiel>(
                LesMateriels.ToList().FindAll(e => e.IdCategorie == uneCategorie.ID_Categorie));
            }

            foreach (Attribution uneAtr in LesAttributions.ToList())
            {
                uneAtr.UnMateriel = LesMateriels.ToList().Find(g => g.ID_Materiel == uneAtr.IdMateriel);
            }

            foreach (Attribution uneAtr in LesAttributions.ToList())
            {
                uneAtr.UnPersonnel = LesPersonnels.ToList().Find(g => g.ID_Personnel == uneAtr.IdPersonnels);
            }

            foreach (Materiel unMat in LesMateriels.ToList())
            {
                unMat.LesAttributions = new ObservableCollection<Attribution>(
                LesAttributions.ToList().FindAll(e => e.IdMateriel == unMat.ID_Materiel));
            }

            foreach (Personnel unPer in LesPersonnels.ToList())
            {
                unPer.LesAttributions = new ObservableCollection<Attribution>(
                LesAttributions.ToList().FindAll(e => e.IdPersonnels == unPer.ID_Personnel));
            }


        }
    }
}
