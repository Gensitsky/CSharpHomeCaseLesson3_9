/*
    Разработайте приложение «7 чудес света», где каждое
    чудо будет представлено отдельным классом. Создай-
    те дополнительный класс, содержащий точку входа.
    Распределите приложение по файлам проекта и с по-
    мощью пространства имён обеспечьте возможность
    взаимодействия классов.
*/
using System;
using Wonders;

namespace CSharpHomeCaseLessone3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wonders of the World:\n");
            Wonder1.Show();
            Wonder2.Show();
            Wonder3.Show();
            Wonder4.Show();
            Wonder5.Show();
            Wonder6.Show();
            Wonder7.Show();

            Console.ReadKey();
        }
    }
}
