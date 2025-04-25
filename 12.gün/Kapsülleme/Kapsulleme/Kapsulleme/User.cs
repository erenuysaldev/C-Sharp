using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme
{
    class User
    {
        private string email; // dışarıya kapalı alan

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz e-posta adresi!");
                }
            }
        }
    }
}