using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_Laba8._1
{
    class Student
    {
        string Name;
        int[]
        marks = new int[10];

        public Student(string name = "Unknown")
    {
        Name = name;
    }

    public int this[int index]
    {
        set { marks[index] = value; }
    }

    public void Rate()
    {
        int buf = 0;
        foreach (int i in marks)
        {
            buf = buf + i;
        }
        Console.WriteLine("Your rate: " + buf / 10);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student Student1 = new Student();
        Student1[0] = 100;
        Student1[1] = 70;
        Student1[2] = 80;
        Student1[3] = 60;
        Student1[4] = 66;
        Student1[5] = 89;
        Student1[6] = 79;
        Student1[7] = 71;
        Student1[8] = 66;
        Student1[9] = 78;
        Console.WriteLine("Введите предложение: ");
        string text = Convert.ToString(Console.ReadLine());

        string[] mystring = text.Split(',', ' ', ',');
        foreach (string i in mystring)
        {
            Console.WriteLine(i);
        }

        Student1.Rate();

    }
}
}
