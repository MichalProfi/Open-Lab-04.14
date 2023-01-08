using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int length = 0;

            foreach (var item in strings)
            {
                if (length < item.Length)
                {
                    length = item.Length;
                }
            }
            string tabs = new string('*', length + 4);

            Console.WriteLine(tabs);
            foreach (var item in strings)
            {
                Console.WriteLine("* " + item.PadRight(length, ' ') + " *");
            }
            Console.WriteLine(tabs);
        }
    }
}