using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class User
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifieldOn { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public int IsBlocked { get; set; }
        public int PasswordCount { get; set; }
    }
}