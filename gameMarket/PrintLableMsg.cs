using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameMarket
{
    class PrintLableMsg
    {
        public delegate bool Condition<T, U>(T arg1, U arg2);

        /// <summary>
        /// функция которая выводит сообщение в Label, об неправильном ввоед текста в поля
        /// </summary>
        /// <param name="func">лямбда для условия true:вывод false:нет</param>
        public static bool printErrorMsg<T, U>(Condition<T, U> func, T str1, U str2, string errorMsg, Label lb)
        {
            if (func(str1, str2))
            {
                if (!lb.Text.Contains(errorMsg))
                {
                    lb.Text += errorMsg + "\n";
                }
                return false;
            }
            else
            {
                lb.Text = lb.Text.Replace(errorMsg + "\n", string.Empty);
                return true;
            }
        }
    }
}
