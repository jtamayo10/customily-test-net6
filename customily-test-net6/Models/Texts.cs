using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class Texts : BaseEntity
    {
        public string Content { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public int ItemId { get; set; }
    }
}