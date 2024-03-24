int n = 10;
int[] arr = new int[n];
int i;

void FillArray(int[] arr)
{
    i = 0;
    while (i < n)
    {
        arr[i] = i + 1;
        i++;
    }
}

void PrintArray(int[] arr) 
{
    i = 0;
    while (i < n)
    {
        Console.Write($"{arr[i]}");
        i++;
    }
}

int GetSumOfElements(int[] arr) 
{
    i = 0;
    int sum = 0;
    while (i < n)
    {
        sum = sum + arr[i];
        i++;
    }
    return sum;
}
int GetProductOfElements(int[] arr)
{
    i =0;
    int product = 1;
    while (i < n)
    {
        product = product * arr[i];
        i++;
    }
    return product;
}

FillArray(arr);
PrintArray(arr);

int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);

Console.WriteLine(" ");
Console.WriteLine(sum);
Console.WriteLine(product);