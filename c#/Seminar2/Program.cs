

//принимает 2 числа и выводит является ли число 1 кратно второму числу. Если не кратно числу 2 то вывод остатка от деления
// Console.Write("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a % b == 0)
//     Console.WriteLine("Число кратно");
// else
//     Console.WriteLine("Число не кратно " + "Остаток = " + (a % b));

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if ((a % 7 == 0) && (a % 23 == 0))
    Console.WriteLine("Число кратно");
else
    Console.WriteLine("Число не кратно ");

