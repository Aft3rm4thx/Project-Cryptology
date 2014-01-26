using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Cipher
    {
        private Dictionary<char, char> _keyMap = new Dictionary<char, char>();
        private const string _ALPHABET_ = "abcdefghijklmnopqrstuvwxyz";          
        private char[] _keyword;

        public Cipher(String keyword)
        {
            this.Keyword = keyword;
        }

        public String Keyword
        {
            get
            {
                string temp = "";
                foreach(char c in _keyword) 
                {
                    temp += c;
                }
                return temp;
            }
            set
            {
                if (_keyMap.Count() > 0) _keyMap.Clear();
                /* Creates a cipher code that has only 26 characters. this is IMPORTANT,
                 * Because it will be used to encode and decode every input.
                 * 
                 */
                _keyword = (value + _ALPHABET_).ToLower().Distinct().ToArray<char>();

                char[] tempAlpha = _ALPHABET_.ToCharArray();
                for (int i = 0; i < _ALPHABET_.Count() && i < _keyword.Count(); i++)
                {
                    _keyMap.Add(tempAlpha[i], _keyword[i]);
                }
            }
        }

        public string Encode(String input)
        {            
            string encoded = "";
            foreach (char c in input.ToLower())
            {
                //Make sure its a letter before translating it
                if (char.IsLetter(c))
                {
                    encoded += _keyMap[c];
                }
                else //Otherwise, we just add it back into the mix.
                {
                    encoded += c;
                }
            }
            return encoded;
        }

        public string Decode(String input)
        {
            string decoded = "";
            foreach (char c in input.ToLower())
            {
                //Make sure its a letter before translating it
                if (char.IsLetter(c))
                {
                    decoded += _keyMap[c];
                }
                else //Otherwise, we just add it back into the mix.
                {
                    decoded += c;
                }
            }
            return decoded;
        }
    }
}
