﻿using MATINFO.MODEL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Materiel : Crud<Materiel>
    {
        private string codeBarre;
        private string nomMateriel;
        private string reference;
        private Categorie categorie;
        private int iD_Materiel;
        private Attribution attribution;
        public Materiel(string codeBarre, string nomMateriel, string reference, Categorie categorie, int idmateriel)
        {
            this.CodeBarre = codeBarre;
            this.NomMateriel = nomMateriel;
            this.Reference = reference;
            this.ID_Categorie = categorie.ID_Categorie;
            this.ID_Materiel = idmateriel;
        }

        public string CodeBarre
        {
            get
            {
                return codeBarre;
            }

            set
            {
                codeBarre = value.ToUpper();
            }
        }

        public string NomMateriel
        {
            get
            {
                return nomMateriel;
            }

            set
            {
                nomMateriel = value.ToUpper();
            }
        }

        public string Reference
        {
            get
            {
                return this.reference;
            }

            set
            {
               this.reference = value.ToUpper();
            }
        }

        public int ID_Materiel
        {
            get
            {
                return this.iD_Materiel;
            }

            set
            {
                this.iD_Materiel = value;
            }
        }

        internal int ID_Categorie
        {
            get
            {
                return this.categorie.ID_Categorie;
            }

            set
            {
                this.categorie.ID_Categorie = value;
            }
        }


        void Crud<Materiel>.Create()
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Delete()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Materiel> Crud<Materiel>.FindAll()
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Materiel> Crud<Materiel>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Read()
        {
            throw new NotImplementedException();
        }

        void Crud<Materiel>.Update()
        {
            throw new NotImplementedException();
        }
    }
}
