using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class Company
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifieldOn { get; set; }
        public string FullName { get; set; }
        public string Communications { get; set; }
        public string ImageLink { get; set; }
        public string Description { get; set; }
        public int Likes { get; set; }
        public int UnLikes { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}