using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class CompanyFeedback
    {
        public int Id { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifieldOn { get; set; }
        public string Comment { get; set; }

        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}