// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
void FindSum(int num1, int num2)
{
    if (num1 < num2)
    {
        if (num2 == num1)
        {
            Console.WriteLine($"Сумма чисел в промежутке от M до N: {sum}");
            return;
        }
        int temp = num2;
        sum += temp;
        FindSum(num1, num2 - 1);
    }
    else if (num1 > num2)
    {
        if (num1 == num2)
        {
            Console.WriteLine($"Сумма чисел в промежутке от M до N: {sum}");
            return;
        }
        int temp = num1;
        sum += temp;
        FindSum(num2, num1 - 1);
    }
    else{
        Console.WriteLine($"Сумма чисел в промежутке от M до N: {sum+num1}");
    }

}
Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
FindSum(num1, num2);