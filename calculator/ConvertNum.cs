using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class ConvertNum
    {
        public int? num1 { get; set; }
        public char? operat { get; set; }
        public int? num2 { get; set; }
        public int? result { get; set; }
        public bool wrnum1 { get; set; }
        public ConvertNum()
        {
            wrnum1 = true;
        }
        public int? Num1(int? num)
        {
            if (wrnum1 == true)
            {
                num1 = Convert.ToInt32(Convert.ToString(num1) + Convert.ToString(num));
                return num1;
            }
            else
            {
                num2 = Convert.ToInt32(Convert.ToString(num2) + Convert.ToString(num));
                return num2;
            }
        }
        public char? Oper(char? op)
        {
            operat = op;
            wrnum1 = false;
            return operat;
        }

        public void Clear()
        {
            wrnum1 = true;
            num1 = null;
            num2 = null;
            operat = ' ';
            result = null;
        }
        public int? operation()
        {
            switch (operat)
            {
                case '/':
                    result = num1 / num2;
                    return result;
                case '*':
                    result = num1 * num2;
                    return result;
                case '-':
                    result = num1 - num1;
                    return result;
                case '+':
                    result = num1 + num2;
                    return result;
                default:
                    return 0;
            }
        }
    }
}
