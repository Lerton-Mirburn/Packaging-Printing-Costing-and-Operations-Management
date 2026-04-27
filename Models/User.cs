using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPCOM.Models
{
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string full_name { get; set; }
        // for database
        public int role_id { get; set; }
        public byte state { get; set; }

        // for display
        public string role_name { get; set; }
        public string state_text { get; set; }
    }
}
