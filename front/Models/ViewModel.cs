using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace front.Models
{
    public class ViewModel
    {
        public IEnumerable<Text> Texts { get; set; }
        public string Name { get; set; }
    }
}
