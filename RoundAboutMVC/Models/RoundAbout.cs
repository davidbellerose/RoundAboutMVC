using System.Collections.Generic;

namespace RoundAboutMVC.Models
{
    public class RoundAbout
    {
        public int RoundValue { get; set; }
        public int AboutValue { get; set; }
        public List<string> Result { get; set; } = new();
    }
}
