using WorkTest.Classes;

namespace SOLID
{


    class Program
    {
        static void Main(string[] args)
        {
            //Вывожу данные на консоль, чтобы проверить конечные результаты
            new Part1().ChangeList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 });
            Console.WriteLine();
            new Part2().ChangeList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });
            Console.WriteLine();
            new Part3().ChangeList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420 });
            Console.ReadKey();
        }
    }
}
