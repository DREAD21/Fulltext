using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace front.Models
{
    public class ViewModel
    {
        public IEnumerable<Text> Texts { get; set; }
        public IEnumerable<Text> Full_Texts { get; set; }

        public string Name { get; set; }
        [Required, RegularExpression(@"[0-9]+")]
        public string validator { get; set;}
        [Required, RegularExpression(@"[a-zA-Z]+")]
        public string validator2 { get; set; }
    }
}
