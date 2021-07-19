using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class StringDisplay: AbstractDisplay
    {
        private string _string;
        private int width;
        public StringDisplay(string str)
        {
            this._string = str;
            Encoding sjisEnc = Encoding.GetEncoding("shift_jis");
            this.width = sjisEnc.GetByteCount(_string);
        }
        public override void Open()
        {
            PrintLine();
        }
        public override void Print()
        {
            Console.WriteLine($"|{_string}|");
        }
        public override void Close()
        {
            PrintLine();
        }
        private void PrintLine()
        {
            Console.Write("+");
            for(int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
