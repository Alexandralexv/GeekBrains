int N = 10;
int[] arr = new int[N];
int i = 0;

while (i < arr.Length) // Можно просто N вместо arr.Length
{
    arr[i] = i + 1;
    //   Console.WriteLine(arr[i]);
    //   Console.WriteLine(" ");
    Console.WriteLine($"{arr[i]} ");
    i++;
}
