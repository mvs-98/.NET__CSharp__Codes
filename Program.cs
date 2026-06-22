// See https://aka.ms/new-console-template for more information
Console.WriteLine("Function to perform left circular rotation of an array");

int[] myArray = new int[5] {23,56,76,43,12};
Console.WriteLine("Orignal Array:");
foreach(int i in myArray)
{
    Console.Write(i+" ");
}
int[] newArray = new int[myArray.Length];
for(int i=0; i<myArray.Length; i++)
{
    newArray[i] = myArray[(i + 1) % myArray.Length];
}
Console.WriteLine("After Left rotation of array the sequence is: ");
foreach(int j in newArray)
{
    Console.Write(j+" ");
}
