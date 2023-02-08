// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

int NumberSum(int rt)
 {
int result = 0;
while(rt>0)
{
    int res = rt%10;
    result = result + res;
    rt=rt/10;
}
return result;
 }

 int rt = GetNumber("Введите первое число: ");
 int result = NumberSum(rt);
Console.WriteLine(result);