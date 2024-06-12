using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    internal class modelAkun
    {
        public class Akun
        {
            public int Id { get; set; }

            public string Username { get; set; }

            public string Nama { get; set; }

            public string Password {  get; set; }

            public string Role { get; set; }

            public Akun(int Id,string Username,string Password,string Nama, string Role)
            {
                this.Id = Id;
                this.Username = Username;
                this.Password = Password;
                this.Nama = Nama;
                this.Role = Role;
            }
        }
    }

}

