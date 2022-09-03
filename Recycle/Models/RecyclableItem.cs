using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Recycle.Models
{
    public class RecyclableItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("RecyclableType")]
        public int RecyclableId { get; set; }
        public RecyclableType RecyclableType { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
        public int Weight { get; set; }
        public int ComputedRate { get; set; }
    }
}