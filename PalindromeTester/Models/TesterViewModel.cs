using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PalindromeTester.Models
{
    public class TesterViewModel
    {
        [DisplayName("Number")]
        [Range(0, int.MaxValue)]
        public int NumberToTest { get; set; }
    }
}
