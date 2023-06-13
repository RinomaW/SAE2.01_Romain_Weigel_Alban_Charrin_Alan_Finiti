using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO.Model
{
    public class Personnel : CRUD
    {
        private string email;
        private string nomPersonnel;
        private string prenom;

        public Personnel(string email, string nomPersonnel, string prenom)
        {
            this.Email = email;
            this.NomPersonnel = nomPersonnel;
            this.Prenom = prenom;
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                int atIndex = email.IndexOf("@");
                int dotIndex = email.LastIndexOf(".");

                if (atIndex > 0 && atIndex > dotIndex)
                {
                    email = value;
                    
                }
                else throw new ArgumentException("l'email n'est pas conforme");

            }
        }

        public string NomPersonnel
        {
            get
            {
                return nomPersonnel;
            }

            set
            {
                int number;
                if (int.TryParse(value, out number))
                    throw new ArgumentException("que en string");
                else nomPersonnel = value.ToUpper();
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                this.prenom = value.Substring(0, 1).ToUpper() + value.Substring(1);
            }
        }

        public override void Create()
        {
            base.Create();
        }

        public override void Delete()
        {
            base.Delete();
        }

        public override void Read()
        {
            base.Read();
        }

        public override void Update()
        {
            base.Update();
        }
    }

    public class Personnels
    {
    }
}
