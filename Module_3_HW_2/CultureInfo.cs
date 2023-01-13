using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Module_3_HW_2
{
    public class CultureInfo
    {
        private readonly string _culture;
        private readonly Alphabet _alphabet;
        public CultureInfo(string culture)
        {
            _culture = culture;
            switch (_culture)
            {
                case "en-US":
                    AlphabetRange = "A-Za-z";
                    break;
                case "uk-UA":
                    AlphabetRange = "А-Яа-я";
                    break;
                default:
                    AlphabetRange = "A-Za-z";
                    break;
            }

            _alphabet = new Alphabet(this);
            _alphabet.AlphabetRange = AlphabetRange;
        }

        public string AlphabetRange { get; set; }

        public bool IsValidCharacter(char c)
        {
            return _alphabet.IsValidCharacter(c);
        }
    }
}