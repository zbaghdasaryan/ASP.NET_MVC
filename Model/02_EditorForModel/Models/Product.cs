using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02_EditorForModel.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsTangible { get; set; }
    }
}