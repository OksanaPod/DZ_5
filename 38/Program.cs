Console.WriteLine("Одномерный массив, заполненный  числами вводимыми с клавиатуры.");
double[] arr = new double[10];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToDouble(Console.ReadLine());
}
double max = arr[0];
double min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) { max = arr[i]; }
    if (arr[i] < min) { min = arr[i]; }
}
Console.WriteLine("\n разница между минимальным и максимальным значением = {0}", max-min);