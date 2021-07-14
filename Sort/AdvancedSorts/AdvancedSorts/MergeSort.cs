using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedSorts
{
    class MergeSort
    {

        public void Sort( double  [] array , int start , int End )
        {
            if (start < End)
            {
                int middle = (start + (End - 1)) / 2;
                Sort(array, start, middle);
                Sort(array, middle + 1, End);
                merge(array, start, middle, End);
            }

        }
        void merge ( double [] array , int Start , int middle , int End)
        {
            int i = Start;
            int j = middle + 1;
            double[] temp = new double[End - Start + 1];
            for ( int k=0; k <= j; k ++)
            {
                if (i== middle+1 && j== End+1)
                {

                }
                else if ( i == middle+1)
                {
                    temp[k] = array[j];
                    j++;
                }
                else if (j == End+1)
                {
                    temp[k] = array[i];
                    i++;
                }
                else if (array[i] > array[j])
                {
              

                   

                    if (j <= End)
                    {
                        temp[k] = array[j];
                        
                        j++;
                    }
                   
                    else if (i <= middle)
                    {
                        temp[k] = array[i];
           
                        i++;
                    }

                }
                else
                {
                    if (i <= middle)
                    {
                        temp[k] = array[i];
               
                        i++;
                    }

                    else if (j <= End)
                    {
                        temp[k] = array[j];
                   
                        j++;
                    }

                }

            }
            int S = Start;
            for (int k = 0; k < temp.Length; k++)
            {
                array[S] = temp[k];
                S++;
            }

        }


    }
}
