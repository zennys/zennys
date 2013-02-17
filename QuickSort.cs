using System;
using System.Collections.Generic;

/*Write a program that sorts an array of strings using the quick sort algorithm
 * http://en.wikipedia.org/wiki/Quicksort */

class Program
    {
       
            static List<string> QSort(List<string> array)
        {
            if (array.Count <= 1)
            {
                return array;
            }

            string pivot = array[array.Count / 2];
            List<string> left = new List<string>();
            List<string> right = new List<string>();

            for (int i = 0; i < array.Count; i++)
            {
                if (i != (array.Count / 2))
                {
                    bool isEqual = true; 
                    bool isBigger = true; 
                    string str = array[i];
 
                    if (str.Length <= pivot.Length)
                    {
                        for (int index = 0; index < str.Length; index++)
                        {
                            if (str[index] != pivot[index])
                            {
                                isEqual = false;

                                if (str[index] < pivot[index])
                                {
                                    isBigger = false;
                                }

                                break;
                            }
                        }

                        if (isEqual && str.Length < pivot.Length)
                        {
                            isBigger = false;
                        }
                    }
                    else if (str.Length > pivot.Length)
                    {
                        for (int index = 0; index < pivot.Length; index++)
                        {
                            if (str[index] != pivot[index])
                            {
                                isEqual = false;

                                if (str[index] < pivot[index])
                                {
                                    isBigger = false; // secondString is BIGGER
                                }

                                break;
                            }
                        }
                    }

                    if (isBigger)
                    {
                        right.Add(array[i]);
                    }
                    else
                    {
                        left.Add(array[i]);
                    }
                }
            }
            List<string> result = new List<string>();
            
            result.AddRange(QSort(left));
            result.Add(pivot);
            result.AddRange(QSort(right));

            return result;
        }

        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            List<string> strList = new List<string>();

            for (int index = 0; index < length; index++)
            {
                strList.Add(Console.ReadLine());
            }

            List<string> sortedList = QSort(strList);

        Console.WriteLine();
        foreach (string str in sortedList)
        {
            Console.WriteLine(str);
        }
        
        }
    
}

