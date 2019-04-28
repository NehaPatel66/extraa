using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace extraa.Models
{
    public class Customer
    {
        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Address { get; internal set; }
    }
}