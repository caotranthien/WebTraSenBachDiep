﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSenBachDiep.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerAddress { get; set; }
        [Required]
        public string CustomerEmail { get; set; }
        [Required]
        public string CustomerMobile { get; set; }
        [Required]
        public string CustomerMessage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        [Required]
        public bool Status { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetail { get; set; }
    }
}
