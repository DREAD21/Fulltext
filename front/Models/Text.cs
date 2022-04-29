using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace front.Models
{
    public class Text
    {
        [RegularExpression(@"[0-9]+", ErrorMessage="Неверные данные")]
        public int Id { get; set; }
        [RegularExpression(@"[a-bA-B]+", ErrorMessage="Неверные данные")]
        public string text { get; set; }
    }
}
