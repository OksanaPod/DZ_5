Console.WriteLine("Одномерный массив из 30 случайных чисел(трехзначных).");
int[] arr = new int[30];
Random rand = new Random();
int n = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 10 == 0) { Console.WriteLine(""); }
    arr[i] = rand.Next(100,1000);
    Console.Write($"{arr[i]},");
    if (arr[i]%2==0)
    {
        n = n + 1;
    }
}
Console.WriteLine("\n Количество четных чисел- {0}", n);