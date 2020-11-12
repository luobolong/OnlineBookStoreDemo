using System;
using System.Collections.Generic;
using System.Text;

namespace Helper.Models
{
    public class GenreModel
    {
        public string Clc { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Clc + " " + Name;
        }
    }
}
