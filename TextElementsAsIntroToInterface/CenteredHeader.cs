using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextElementsAsIntroToInterface
{
    internal class CenteredHeader
    {
        private string _text;
        private char _paddingChar;

        public CenteredHeader(string text, char paddingChar)
        {
            _paddingChar = paddingChar;
            _text = text;
        }

        public void Show()
        {
            var startPos = (Console.WindowWidth - _text.Length) / 2;
            var dashCount = startPos - 4;
            var dashes = "  " + new string(_paddingChar, dashCount) + "  ";
            Console.Write(dashes);
            Console.Write(_text);
            Console.WriteLine(dashes);
        }
    }
}
