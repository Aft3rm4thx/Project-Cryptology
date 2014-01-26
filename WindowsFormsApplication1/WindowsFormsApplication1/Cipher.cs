using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cipher
    {
        private const String _ALPHABET_ = "abcdefghijklmnopqrstuvwxyz";
        private char[] _keyword;

        public Cipher(String keyword)
        {
            this.Keyword = keyword;
        }

        public String Keyword
        {
            get
            {
                return _keyword.ToString();
            }
            set
            {
                /* Creates a cipher code that has only 26 characters. this is IMPORTANT,
                 * Because it will be used to encode and decode every input.
                 * 
                 */
                _keyword = (value + _ALPHABET_).Distinct().ToArray<char>();
            }
        }

        public string Encode(String input)
        {
            string encoded = "";
            foreach (char c in input.ToCharArray())
            {
                int index = _ALPHABET_.IndexOf(c);
                encoded += _keyword[index];                
                
            }
            return encoded;
        }

        public string Decode(String input)
        {
            string decoded = "";
            foreach (Char c in input)
            {
                decoded += _ALPHABET_.ToCharArray()[_keyword.ToString().IndexOf(c) - 1];

            }
            return decoded;
        }
    }
}
