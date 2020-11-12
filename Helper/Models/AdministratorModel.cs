using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Models
{
    public class AdministratorModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Real_Name { get; set; }
        public string Password_Hash { get; set; }
        public string Email_Address { get; set; }
    }
}
