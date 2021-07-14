using System;
using System.Collections.Generic;
using System.Text;

namespace SparseMatrix
{
    class Functions
    {
        SparseMatrix sparse = new SparseMatrix();
        List<MatrixTerm> AuxillaryArray;
        string result;
        public void trasnpose()
        {
            AuxillaryArray = null;
            AuxillaryArray = new List<MatrixTerm>();

            int[] Rowsize = new int[SparseMatrix.Columns+1];
            int[] Rowstart = new int[SparseMatrix.Columns+1];
          
            for (int i = 0; i < sparse.sparray.Count; i++) // sparse.sparray.Count = Terms 
            {
                Rowsize[sparse.sparray[i].col]++;
            }

            for (int i = 0; i < Rowstart.Length; i++) // rowstart.length = cols 
            {
                if (i == 0)
                    Rowstart[0] = 0;
                else 
                    Rowstart[i] = Rowstart[i - 1] + Rowsize[i - 1];
            }
          

            for (int i = 0; i < sparse.sparray.Count; i++) // sparse.sparray.Count = Terms 
            {
                AuxillaryArray.Add(new MatrixTerm(sparse.sparray[i].row, sparse.sparray[i].col, sparse.sparray[i].value) );
            }

            for (int i = 0; i < sparse.sparray.Count; i++)
            {
                int Whereiscol = Rowstart[sparse.sparray[i].col];
                AuxillaryArray[Whereiscol].value = sparse.sparray[i].value;
                AuxillaryArray[Whereiscol].row = sparse.sparray[i].col;
                AuxillaryArray[Whereiscol].col = sparse.sparray[i].row;
                Rowstart[sparse.sparray[i].col]++;
            }
            sparse.sparray = AuxillaryArray;

        }

        public void Matris(int row, int col, double value)
        {
      
            sparse.sparray.Add(new MatrixTerm(row, col, value));
            if (SparseMatrix.Columns < col)//update the larger col
                SparseMatrix.Columns = col;
        }

        public override string ToString()
        {
            result = "";
            for (int i = 0; i < sparse.sparray.Count; i++)
            {
                 result += string.Format("Row : {0} , Column : {1} ,  Value : {2}\n", sparse.sparray[i].row, sparse.sparray[i].col,  sparse.sparray[i].value);
            }
            return result;
            
        }


    }
}
