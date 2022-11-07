using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class Images : BaseEntity
    {
        public string URL { get; set; }
        public long X { get; set; }
        public long Y { get; set; }
        public int ItemId { get; set; }
    }
}