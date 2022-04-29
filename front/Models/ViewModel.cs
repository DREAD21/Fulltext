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
        [RegularExpression(@"[a-bA-B]+"), ErrorMessage=("Неверные данные")]
        public string Name { get; set; }
    }
}
