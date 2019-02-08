using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        //List<int> intList = new List<int>();
        //intList.Add(4); // add to the list
        //intList.Add(10);
        //intList.Remove(10); // remove from the list

        List<string> stringList = new List<string>();
        stringList.Add("Hello"); // add to the list
        stringList.Add("Jefe");
        stringList.Remove("Jefe"); // remove from the list

        Console.WriteLine(stringList[0]);
        Console.ReadLine();

        // a 'byte array' can be useful for very large arrays
        byte[] byteArray = new byte[5000];


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //// you can accomplish the same as above with less code
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        //// again you can accomplish this with even less code
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //// this will change the value located at index 5 of this array
        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

