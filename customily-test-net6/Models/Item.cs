using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class Item : BaseEntity
    {
        public string Title { get; set; }
        [ForeignKey("ItemId")]
        public List<Images> Images { get; set; }
        [ForeignKey("ItemId")]
        public List<Texts> Texts { get; set; }
    }
}