using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class DoubleStack
    {
        int Maximum;
        int Top1;
        int Top2;
        string[] element;

        public DoubleStack(int size)  // size tedad mashin haye dakhel parking
        {
            Maximum = size;
            element = new string[size];
            Top1 = -1;
            Top2 =  size;
        }

        public bool Push1(string obj)
        {
            if (Top1 == Top2)
            {
                Console.WriteLine("stack is full");
                return false;
            }
            else
            {
                element[++Top1] = obj;
                return true;
            }

        }


        public string Pop1()
        {
            if (Top1 == -1)
            {
                return "stack is Empty!";
            }
            else
            {
                string outp = element[Top1];
                element[Top1--] = "";         // stack ro khali mikonim ta dade invalid tosh namone 
                return outp;


            }
        }


        public bool Push2(string obj)
        {
            if (Top1+1 == Top2)
            {
                Console.WriteLine("stack is full");
                return false;
            }
            else
            {
                element[--Top2] = obj;
                return true;
            }

        }


        public string Pop2()
        {
            if (Top2 == Maximum)
            {
                return "stack is Empty!";
            }
            else
            {
                string outp = element[Top2];
                element[Top2++] = "";         // stack ro khali mikonim ta dade invalid tosh namone 
                return outp;


            }
        }



    }
}
