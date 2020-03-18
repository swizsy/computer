using System;
using System.Collections.Generic;

namespace Computer
{
    public class Gpu
    {
        public void Display(string text)
        {
            Console.WriteLine(text);
        }

        public void DisplayOptions()
        {
            Display(Constants.CHOOSE_OPTION);
            Display(Constants.OPTION_SAVE);
            Display(Constants.OPTION_READ);
            Display(Constants.OPTION_FORMAT);
            Display(Constants.OPTION_QUIT);
        }

        public void DisplayRecords(List<string> records)
        {
            foreach (var record in records)
            {
                Display(record);
            }
            Console.WriteLine();
        }
    }
}