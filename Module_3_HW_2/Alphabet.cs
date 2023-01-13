using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Module_3_HW_2
{
    public class Alphabet
    {
        private readonly CultureInfo _culture;
        public Alphabet(CultureInfo culture)
        {
            _culture = culture;
            AlphabetRange = culture.AlphabetRange;
        }

        public string AlphabetRange { get; set; }

        public string GetFirstLetter(string name)
        {
            return name.Substring(0, 1);
        }

        public string GetGroupName(string firstLetter)
        {
            int valid;
            if (int.TryParse(firstLetter, out valid))
            {
                return "0-9";
            }

            if (!Regex.IsMatch(firstLetter, "[" + AlphabetRange + "]"))
            {
                return "#";
            }

            return firstLetter.ToUpper();
        }

        public bool IsValidCharacter(char c)
        {
            if (AlphabetRange == null)
            {
                Console.WriteLine("Alphabet range is null");
                return false;
            }

            bool isInAlphabetRange =
                Regex.IsMatch(char.ToString(c), "[" + AlphabetRange + "]");
            if (!isInAlphabetRange)
            {
                isInAlphabetRange =
                    Regex.IsMatch(char.ToString(c), "[0-9]");
            }

            return isInAlphabetRange;
        }
    }
}
