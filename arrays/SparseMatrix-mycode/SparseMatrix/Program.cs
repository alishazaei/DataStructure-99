using System;

namespace SparseMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions F = new Functions();
            F.Matris( 0,0,15);
            F.Matris(0,4,91);
            F.Matris(1,1,11);
            F.Matris(2,1,3);
            F.Matris(2,5,28);
            F.Matris(3,0,22);
            F.Matris(3,2,-6);
            F.Matris(5,0,-15);
            F.trasnpose();
            Console.WriteLine( F ) ;
        }
    }
}
