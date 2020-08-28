using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Gib Zahl");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Gib Zahl2");
            //int y = int.Parse(Console.ReadLine());

            //int z = x + y;
            //Console.WriteLine("Zahl + Zahl2 ist {0}",z);

            //const int x = 5;
            //Console.WriteLine("Gib Zahl");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Gib Zahl2");
            //int z = int.Parse(Console.ReadLine());

            //int x1 = y * z;
            //int x2 = x1 * x;

            //Console.WriteLine("Es sind {0} m^2 und kostet dich {1} euro",x1,x2);

            //Console.WriteLine("Gib Minuten");
            //int x = int.Parse(Console.ReadLine());

            //int y = x / 60;
            //int z = x % 60;

            //Console.WriteLine("du opferst {0} Stunden und {1} Minuten deines lebens", y, z);

            //int x = 5;
            //int y = 6;

            ////(condition) ? true : false
            //int z = x > y ? x : y;

            //Console.WriteLine("studenrate");
            //double x = double.Parse(Console.ReadLine());



            //if (7.5<x && x<49)
            //{
            //    Console.WriteLine("rate ist okay");
            //}
            //else
            //{
            //    Console.WriteLine("rate nicht okay");
            //}
            //int b = 20;

            //Console.WriteLine("länge");
            //double x = double.Parse(Console.ReadLine());
            //Console.WriteLine("breite");
            //double y = double.Parse(Console.ReadLine());

            //double z = x * y;

            //if (z<400)
            //{
            //    int a = 25;
            //    double c = a * z;
            //    double d = c * b;
            //    Console.WriteLine("dein feld ist {0} m^2 groß es kostet dich {1}€ die woche und 20 wochen kosten {2}", z, c, d);
            //}
            //else if (z>=400 && z<600)
            //{
            //    int a = 35;
            //    double c = a * z;
            //    double d = c * b;
            //    Console.WriteLine("dein feld ist {0} m^2 groß es kostet dich {1}€ die woche und 20 wochen kosten {2}", z, c, d);
            //}
            //else if (z>=600)
            //{
            //    int a = 50;
            //    double c = a * z;
            //    double d = c * b;
            //    Console.WriteLine("dein feld ist {0} m^2 groß es kostet dich {1}€ die woche und 20 wochen kosten {2}", z, c, d);
            //}

            //Random randomGenerator = new Random();
            //int randomNumber = randomGenerator.Next(1, 11);

            //Console.WriteLine("gib zahl zwischen 1 und 10");
            //int x = int.Parse(Console.ReadLine());

            //    if (x == randomNumber)
            //{
            //    Console.WriteLine("richtig!!{0}", randomNumber);
            //}
            //else if (x>randomNumber)
            //{
            //    Console.WriteLine("zu hoch{0}", randomNumber);
            //}
            //else if (x<randomNumber)
            //{
            //    Console.WriteLine("zu niedrig {0}",randomNumber);
            //}

            //for (int i = 0; 0 < 5; i++) ;
            //double x;
            //do
            //{
            //    Console.WriteLine("enter payrate");
            //    x = double.Parse(Console.ReadLine());
            //} while (x < 5.65 || x > 49.99);

            //Console.WriteLine("your payrate is {0}", x);
            //int k = 1;
            //for (int i = 2; i < 51; i++)
            //{
            //    k += i;
            //};
            //Console.WriteLine(k);

            //Random randomGenerator = new Random();
            //int randomNumber = randomGenerator.Next(1, 11);

            //int x;

            //do
            //{

            //    Console.WriteLine("gib zahl zwischen 1 und 10");
            //    x = int.Parse(Console.ReadLine());




            //    //if (x == randomNumber)
            //    //{
            //    //    Console.WriteLine("richtig!!{0}", randomNumber);
            //    //}
            //     if (x > randomNumber)
            //    {
            //        Console.WriteLine("zu hoch");
            //    }
            //     if (x < randomNumber)
            //    {
            //        Console.WriteLine("zu niedrig ");
            //    }
            //}
            //while (x != randomNumber);
            //Console.WriteLine("richtig!!{0}", randomNumber);


            //int[] myArray = new int[3];
            //myArray[0] = 5;

            //int[] myArray2 = new int[3] { 4, 5, 6 };
            //int[] myArray3 = new int[] { 4, 5, 6 };
            //int[] myArray4 = { 4, 5, 6 };


            //Console.WriteLine(myArray[2]);

            //int[] grades = { 55, 76, 88, 99, 100 };

            //for ( int i = 0; i < grades.Length; i++)

            //{
            //    grades[i] += 3;
            //    Console.WriteLine(grades[i]);
            //}

            //foreach (int score in grades)
            //{
            //    Console.WriteLine(score);
            //}

            //string[] students = { "bob", "ted", "dieter", "kekw" };
            //int[] grades = { 77, 50, 78, 99 };

            //Console.WriteLine("enter name");
            //string studentsname = Console.ReadLine();

            //bool contains = false;
            //int studentsgrade =0;

            //for (int i = 0; i <students.Length;i++)
            //{
            //    if (studentsname==students[i])
            //    {
            //        contains = true;
            //        studentsgrade = grades[i];
            //        break;
            //    }
            //}
            //if (contains == true)
            //{
            //    Console.WriteLine("the student is in the class und seine note ist {0}",studentsgrade);
            //}
            //else
            //{
            //    Console.WriteLine("the student is not in the clas");
            //}

            //int[] myArray = { 10, 15, 20, 25, 30, 35, 40 };
            //Console.WriteLine("Gib Zahl");
            //int number = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray, number);
            //if (answer < 0)
            //{
            //    Console.WriteLine("the number gibts nicht");
            //}
            //else
            //{
            //    Console.WriteLine("the number position in the array is {0}", answer);
            //}

            //int[] myArray = { 10, 4, 1, 11, 20 };
            //Array.Sort(myArray);
            //for(int i =0;i<myArray.Length;i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[] myArray = { 1, 2, 5, 7, 10, 11 };
            //Array.Reverse(myArray);

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    Console.WriteLine(myArray[i]);
            //}

            //int[,] myArray = new int[3, 4];
            //myArray[0, 0] = 5;
            //myArray[0, 1] = 6;
            //int[,] myA =
            //{
            //    {5,6,7,8 },
            //    {7,8,9,10},
            //    {7,8,9,10}
            //};
            //for( int i =0;i<3;i++)
            //{
            //    for (int j =0; j<4;j++)
            //    {
            //        Console.Write(myA[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[][] myArray = new int[3][];
            //myArray[0] = new int[4] { 5, 4, 3, 2 };
            //myArray[1] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
            //myArray[2] = new int[1] { 1 };

            //for (int i = 0; i<3;i++)
            //{
            //    for (int j = 0; j < myArray[i].Length;j++)
            //    {
            //        Console.Write(myArray[i][j]);
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
