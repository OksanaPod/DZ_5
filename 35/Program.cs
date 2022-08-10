Console.WriteLine("Одномерный массив из 123 случайных чисел.");
int[] arr = new int[123];
Random rand = new Random();
int n = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 10 == 0) { Console.WriteLine(""); }
    arr[i] = rand.Next(0,1000);
    Console.Write("{0},",arr[i]);
    if (arr[i] <= 99 && arr[i] >= 10)
    {
        n = n + 1;
    }
}
Console.WriteLine("\n Значения которых лежат в отрезке [10,99].- {0}", n);