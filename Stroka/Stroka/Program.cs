using System;

class Stroka
{
    static void Main(string[] args)
        
    
    {
        Console.Write("input kolvo elementov:\t");
        int elementCount = int.Parse(Console.ReadLine());
        int kolvo = elementCount;
        string[] myArray = new string[elementCount];
        for (int k = 0; k < myArray.Length; k++)
        {
            Console.Write($"element index {k+1}:");
            string str1;


            str1 = Console.ReadLine().ToString();

            myArray[k] = str1;
        }

        
        string[] letters = myArray;
        string name = "";
        int[] a = new int[kolvo];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
         Console.ReadKey();
    
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Variant number " + msg + ", word "+ name);
    }
}