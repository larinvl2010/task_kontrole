Console.WriteLine("Enter a number of elements array");
int N =Convert.ToInt32(Console.ReadLine());
string[] array=new string[N];
Console.WriteLine("Enter strings");
for (int i = 0; i<array.GetLength(0); i++)
    {
        array[i]=Console.ReadLine();
    }
PrintArray(array);
Console.WriteLine("--------------------");
SelectionArray(array);
void PrintArray(string [] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        
            Console.Write($"{array[i]} ");
    
    }
Console.WriteLine();
}

void SelectionArray(string [] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        if (array[i].Length<=3)
        {
            Console.Write($"{array[i]} ");
        }
    
    }
}