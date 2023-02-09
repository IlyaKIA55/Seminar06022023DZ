// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите 8 чисел через запятую");
string [] strArray = Console.ReadLine().Split(',');

// int Number(string message)
// {
// Console.WriteLine(message);
// int numb = Convert.ToInt32(Console.ReadLine());
// return numb;
// }

int[] result = new int[strArray.Length];
// Console.WriteLine(result.Length);

// if (result.Length ==8)
// {
   for (int i = 0; i < result.Length; i++)
{
    result[i] = int.Parse(strArray[i]);
}
    Console.WriteLine(string.Join(',', result));
// }
// else 
// {
//     Console.WriteLine("В введеном числе не 8 цифр");
// }