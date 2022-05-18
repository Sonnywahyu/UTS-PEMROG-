using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen Data1 = new Dosen();
            Data1.dosen();
            Console.Write("Masukkan nama dosen yang mengajar : ");
            Data1.Nama = Console.ReadLine();
            Console.Write("Masukkan NIK dosen yang mengajar : ");
            Data1.NIK = Convert.ToInt32(Console.ReadLine());
            Console.Write("input Gender dosen yang mengajar : ");
            Data1.Gender = Console.ReadLine();
            Console.Write("Masukkan mata kuliah yang diajarkan {0} : ", Data1.Nama);
            Data1.Course = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Data Dosen");
            Data1.dosen();
            Data1.attDosen(Data1.Nama, Data1.NIK, Data1.Gender);
            Data1.addCourse(Data1.Course);
            Console.ReadLine();
        }
    }
}
