using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[5];
            students[0] = new Student(90, 80);
            students[1] = new Student(24, 90);
            students[2] = new Student(100, 50);
            students[3] = new Student(50, 90);
            students[4] = new Student(30, 80);

            Console.Write("請輸入排序順序，小到大選1，大到小選2:");
            int OrderOption = int.Parse(Console.ReadLine()); 
        
  //          for (int index = 0; index < vectors.Length; index++)
            Student.Order = OrderOption == 1 ? 1:-1;

            Console.WriteLine("排序前");
            for (int index = 0; index < students.Length; index++)
                Console.WriteLine(students[index]);
            Array.Sort(students);

            Console.WriteLine("排序後");
            for (int index = 0; index < students.Length ; index++)
                Console.WriteLine(students[index]);

        }
    }
}
