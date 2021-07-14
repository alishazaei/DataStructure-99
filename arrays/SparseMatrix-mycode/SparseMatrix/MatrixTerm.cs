using System;
using System.Collections.Generic;
using System.Text;

namespace SparseMatrix
{
    class MatrixTerm
    {
        public int row;
        public int col;
        public double value; 
        public MatrixTerm(int row , int col , double value)
        {
            this.row = row;
            this.col = col;
            this.value = value;

        }
    }
}
