// See https://aka.ms/new-console-template for more information
Console.WriteLine("Function to perform left circular rotation of an array");

try
{
    Console.WriteLine("Enter 5 array elements with spaces in between them");
    string arrayelements = Console.ReadLine();
    int[] myArray = arrayelements.Split(" ").Select(int.Parse).ToArray();
    Console.WriteLine("Orignal Array:");
    foreach (int i in myArray)
    {
        Console.Write(i + " ");
    }
    int[] newArray = new int[myArray.Length];
    for (int i = 0; i < myArray.Length; i++)
    {
        newArray[i] = myArray[(i + 1) % myArray.Length];
    }
    Console.WriteLine("\nAfter Left rotation of array the sequence is: ");
    foreach (int j in newArray)
    {
        Console.Write(j + " ");
    }
}
catch
{
    Console.WriteLine("\nSomething went wrong, check if you inputted array elements with proper spaces by eleminating any front or tailing spaces");
}
