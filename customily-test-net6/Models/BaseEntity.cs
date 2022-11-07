using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public Nullable<DateTime> CreatedDate { get; set; }
        public Nullable<DateTime> ModfiedDate { get; set; }

        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}