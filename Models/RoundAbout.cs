using System.Collections.Generic;

namespace RoundAboutMVC.Models
{
    public class RoundAbout
    {
        public int RoundValue { get; set; }
        public int AboutValue { get; set; }
        public int StartValue { get; set; }
        public int EndValue { get; set; }
        public string FirstWord { get; set; }
        public string LastWord { get; set; }

        public List<string> Result { get; set; } = new();
    }
}
