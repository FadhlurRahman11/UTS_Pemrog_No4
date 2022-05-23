using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomor4
{
    class Program
    {
        static void Main(string[] args)
        {
            dosen Dosen1 = new dosen();
            Dosen1.attDosen(1, "Fadhlur", 21114349);
            Dosen1.addCourse("Pemrograman");
            Dosen1.Tampilan();
            Console.WriteLine();

            dosen Dosen2 = new dosen();
            Dosen2.Tampilan();

            Console.ReadKey();
        }
    }
}
