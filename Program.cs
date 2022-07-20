namespace CSharpLessons
{
    class MyProgram
    {
        private static void Task_1()
        {
            Boolean IsOutOfLoop = true;
            do
            {
                IsOutOfLoop = true;
                Console.Write("Введите число: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                if (Number / 10000 > 0)
                {
                    Console.Write("\n" + Number.ToString() + " - ");
                    if (Number % 10 != Number / 10000 || Number % 100 / 10 != Number % 10000 / 1000)
                    {
                        Console.Write("не ");
                    }
                    Console.Write("палиндром.");
                }
                else
                {
                    Console.WriteLine("Число должно быть пятизначным... \nПовторите попытку! \n");
                    IsOutOfLoop = false;
                }
            } while (IsOutOfLoop == false);
        }

        private static void Task_2()
        {
            Console.WriteLine("Введите координаты точки A: ");
            Console.Write("A(X) = ");
            double Ax = Convert.ToDouble(Console.ReadLine());
            Console.Write("A(Y) = ");
            double Ay = Convert.ToDouble(Console.ReadLine());
            Console.Write("A(Z) = ");
            double Az = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки B: ");
            Console.Write("B(X) = ");
            double Bx = Convert.ToDouble(Console.ReadLine());
            Console.Write("B(Y) = ");
            double By = Convert.ToDouble(Console.ReadLine());
            Console.Write("B(Z) = ");
            double Bz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nРасстояние между точкой A и точкой B = " + Math.Sqrt(Math.Pow(Bx - Ax, 2d) + Math.Pow(By - Ay, 2d) + Math.Pow(Bz - Az, 2d)).ToString() + ".");
        }

        private static void Task_3()
        {
            Console.Write("Введите число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nРезультат: ");
            for (int i = 1; i <= N; i++)
            {
                Console.Write(" " + Math.Pow(Convert.ToDouble(i), 3).ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Boolean IsOutOfLoop = true;

            do
            {
                IsOutOfLoop = true;
                switch (N)
                {
                    case 1:
                        Console.WriteLine("Задача про палиндром: \n");
                        Task_1();
                        break;
                    case 2:
                        Console.WriteLine("Задача расстояние меж двух точек: \n");
                        Task_2();
                        break;
                    case 3:
                        Console.WriteLine("Задача про кубы чисел от 1 до N: \n");
                        Task_3();
                        break;
                    default:
                        Console.WriteLine("Нет такой задачи!: \n");
                        IsOutOfLoop = false;
                        break;
                }
            } while (IsOutOfLoop == false);
        }
    }
}