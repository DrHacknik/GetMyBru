using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace GetMyBru.GetMyBru.Core
{
    class ILogging
    {
        public static void Output(bool IError, bool ISystem, bool IUpdate, bool _Info, string IText, bool _IsNewLine)
        {
            if (IError == true)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine(DateTime.Now + ": Error:: " + IText);
                return;
            }
            if (ISystem == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(DateTime.Now + ": System:: " + IText);
                return;
            }
            if (IUpdate == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(DateTime.Now + ": Update:: " + IText);
                return;
            }
            if (_Info == true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (_IsNewLine == true)
                {
                    Console.WriteLine();
                    Console.WriteLine(DateTime.Now + ": Info:: " + IText);
                }
                else
                {
                    Console.Write("\r" + DateTime.Now + ": Info:: " + IText);
                }
              
            }
        }
    }
}

