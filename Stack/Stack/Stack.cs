using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Stack
    {

        int Maximum;
        int Top;
        string[] element;

        public Stack(int size)  // size tedad mashin haye dakhel parking
        {
            Maximum = size;
            element = new string[size];
            Top = -1;
        }

        public bool Push(string obj)
        {
            if (Top == Maximum - 1)
            {
                return false;
            }
            else
            {
                element[++Top] = obj;
                return true;
            }

        }


        public string Pop()
        {
            if (Top == -1)
            {
                return "stack is Empty!";
            }
            else
            {
                string outp = element[Top];
                element[Top--] = "";         // stack ro khali mikonim ta dade invalid tosh namone 
                return outp;


            }
        }
        public string Display()
        {
            string result = "";
            for (int i = 0; i <= Top; i++)
            {
                if (element[i] != "")
                    result += element[i] + "\n";
            }

            return result;

        }



    }
}
