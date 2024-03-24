int N = 5;
int[] arr = { 2, 22, 7, 3, 9 };
int i = 0;
int max = arr[0];

while (i < N)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
Console.WriteLine(max);
