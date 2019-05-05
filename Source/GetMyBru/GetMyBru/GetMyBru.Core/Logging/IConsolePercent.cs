using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetMyBru.GetMyBru.Core
{
    public class ConsoleSpinner
    {
        int counter;
        public ConsoleSpinner()
        {
            counter = 0;
        }
        public void Turn()
        {
            counter++;
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            try
            {
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            catch
            {
                return;
            }

        }
    }
}
