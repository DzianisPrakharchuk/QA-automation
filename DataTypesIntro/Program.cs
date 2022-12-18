// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("1.Create and randomly populate an array of type int to store grades for subjects.");


{
    // Объявляем массив
    int[] Arr = new int[10];

    // присваиваем значение каждому элементу массива 
    Arr[0] = 10;
    Arr[1] = 9;
    Arr[2] = 9;
    Arr[3] = 7;
    Arr[4] = 4;
    Arr[5] = 7;
    Arr[6] = 10;
    Arr[7] = 6;
    Arr[8] = 9;
    Arr[9] = 1;

    var str = string.Join(" ", Arr);

    Console.WriteLine("Numbers: " + str);

   

    //находим сумму элементов
    //массива в переменной numbersSum

    int numbersSum = 0;

    for (int i = 0; i < Arr.Length; i++)

        numbersSum = numbersSum + Arr[i];

    Console.WriteLine("2. Calculate and display the middle score.");

    //находим среднее знаение  элементов массива 

      int average = 0;
    
      average = numbersSum / Arr.Length;

    Console.WriteLine("Average number:  " + average);

    Console.WriteLine("3. Find the maximum and minimum rating in the array and print to the display");

    //находим максимальную и минимальную велиину в массиве 

    int maxvalue = Arr[0];

    int minvalue = Arr[0];

    for (int i = 1; i < Arr.Length; i++)
    {
        if (Arr[i] > maxvalue)
        {
            maxvalue = Arr[i];
            
        }
        else if (Arr[i] < minvalue)
        {
            minvalue = Arr[i];
            
        }
        
    }
    Console.WriteLine("Maxvalue   " + maxvalue);

    Console.WriteLine("Minvalue   " + minvalue);


}





