Console.WriteLine(" Одномерный массив, заполненный случайными числами. .");
int[] arr = new int[10];
Random rand = new Random();
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (i % 10 == 0) { Console.WriteLine(""); }
    arr[i] = rand.Next(-100,100);
    Console.Write("{0},",arr[i]);
    if (i%2!=0)
    {
        sum = sum + arr[i];
    }
}
Console.WriteLine("\n Сумма чисел стоящих на нечетных позициях= {0}", sum);