using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrsServer.Models
{
    public class Request
    {
        public int Id { get; set; }
        [StringLength(80), Required]
        public string Description { get; set; }
        [StringLength(80), Required]
        public string Justfication { get; set; }
        [StringLength(80)]
        public string RejectionReasson { get; set; }
        [StringLength(20), Required]
        public string DeliveryMode { get; set; } = "PickUp";
        [StringLength(10), Required]
        public string Status { get; set; } = "New";
        [Column(TypeName = "decimal (11,2)")]
        public decimal Total { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        // public virtual IEnumerable<RequestLine> RequestLines { get; set; } 

        public Request() { }
    }
}
