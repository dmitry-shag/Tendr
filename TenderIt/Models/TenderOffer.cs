using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TenderIt.Models
{
    public class TenderOffer
    {
        public int Id { get; set; }
        public string Offer { get; set; }
        public DateTime? CreateOn { get; set; }

        public int? TenderId { get; set; }
        [ForeignKey("TenderId")]
        public virtual Tender Tender { get; set; }

        public int? CompanyId { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}