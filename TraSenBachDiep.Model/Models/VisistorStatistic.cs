using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraSenBachDiep.Model.Models
{
    [Table("VisistorStatistics")]
    public class VisistorStatistic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisistedDate { get; set; }
        [Required]
        public string IPAddress { get; set; }
    }
}
