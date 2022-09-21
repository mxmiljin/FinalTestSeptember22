using System;
class Program
{
    static void Main(string[] args)
    {    
        Console.Write("Введите слова или символы, разделенные запятой: ");
        string inputData = Console.ReadLine();
        string noSpaceData = inputData.Replace(" ", "");
        string[] DataArray = noSpaceData.Split(",");
        
        Console.Write("Элементы списка, содержащие 3 или меньше символов: ");

        for (int i = 0; i < DataArray.Length; i++)
        {
            if (DataArray[i].Length <= 3)
            { 
                Console.Write(DataArray[i] + " ");
            }
        }
    }
}
