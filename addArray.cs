int[] newArray = { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < newArray.Length; i++)
{
    sum += newArray[i];
}
System.Console.WriteLine($"Sum is: {sum}");