﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSenBachDiep.Model.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]
   
        public int OrderID { get; set; }
        [Key]
    
        public int ProductID { get; set; }
        public int Quanlity { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
        [ForeignKey("ProducID")]
        public virtual Product Product { get; set; }

    }
}
