// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int ferstNum = Input("Введите число А"),
    secondNum = Input("Введите число В");
double result = 1;

for(int i = 0; i < Module(secondNum); i++)
{
    result *= ferstNum;
}
if(secondNum < 0)
    {
        result = 1/result;
    }
Console.WriteLine($"Число А в степени В: {result}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int num = Input("Введите число"),
    resultTask27 = 0;

int tempNum = Module(num);
string arg = Convert.ToString(tempNum);

for (int i = 0; i < arg.Length; i++)
{
    resultTask27 += arg[i] - '0'; 
}
Console.WriteLine($"Сумма всех цифр в числе {num}: {resultTask27}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Вывод сделать отдельным методом.

int[] array = new int[8];
for(int i = 0; i < array.Length; i++ )
{
    array[i] = new Random().Next(-100,101);
}
PrintArray(array);

// Методы 

int Input(string str)
{
    Console.WriteLine(str);
    return Convert.ToInt32(Console.ReadLine());

}

int Module(int x)
{
    if (x < 0)
    {
        x *= -1; 
    }
    return x;
}

void PrintArray(int[] arr)
{
    string result = "[";
    for(int i = 0; i < array.Length; i++ )
    {
        string ch = ", ";
        if(i == array.Length -1)
        {
            ch = "]";
        }
        result += array[i] + ch;
    }
    Console.WriteLine($"Array to string {result}");
}
