﻿using MATINFO.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Categorie : CRUD
    {
        private string nomCategorie;
        private int iD_Categorie = 1;
        public HashSet<string> nomUniques;

        public Categorie(string nomCategorie)
        {
            testNomUnique();
            this.NomCategorie = nomCategorie;
            this.ID_Categorie++;
        }

        public Categorie()
        {
        }

        public string NomCategorie
        {
            get
            {
                return this.NomCategorie;
            }

            set
            {
                if (this.NomCategorie is null)
                    throw new ArgumentNullException("Ce champ ne peut pas être null");
                this.NomCategorie = value;
            }
        }

        public int ID_Categorie
        {
            get
            {
                return this.iD_Categorie;
            }

            set
            {
                this.iD_Categorie = value;
            }
        }


        public void testNomUnique()
        {
            if (nomUniques.Contains(this.NomCategorie))
            {
                // La variable existe déjà
                throw new ArgumentException("le nom n'est pas unique");
            }
            else
            {
                // La variable est unique, l'ajouter au HashSet
                nomUniques.Add(this.NomCategorie);
            }
        }

        public override void Create()
        {
            base.Create();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Delete()
        {
            base.Delete();
        }

        public override void Select()
        {
            base.Select();
        }
        public ObservableCollection<Categorie> FindAll()
        {
            ObservableCollection<Categorie> LesCategorie = new ObservableCollection<Categorie>();
            DataAccess accesBD = new DataAccess();
            String requete = "select * from categorie_materiel;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Categorie e = new Categorie(row["nomcategorie"].ToString());
                    LesCategorie.Add(e);
                }
            }
            return LesCategorie;
        }

    }
}
