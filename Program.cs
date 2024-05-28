using System;
using System.Diagnostics;

namespace _
{
    class Program
    {
        static int counter = 0;
        static int swaps = 0;

        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();

            int[] unSortedArray = genArray(3000);

            int[] arrayBubblev1 = CopyArray(unSortedArray);
            int[] arrayBubblev2 = CopyArray(unSortedArray);
            int[] arrayBubblev3 = CopyArray(unSortedArray);
            int[] arrayBubblev4 = CopyArray(unSortedArray);
            int[] arraySelectv1 = CopyArray(unSortedArray);
            int[] arraySelectv2 = CopyArray(unSortedArray);

            /*PrintArray(unSortedArray);
            Console.WriteLine();*/



            sw.Start();
            BubbleSort_v1(arrayBubblev1);
            sw.Stop();

            Console.WriteLine("Bubble_v1");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("---------------------------------------------------");

            //----------------------------------------------------------------------------------------------------------

            counter = 0;
            swaps = 0;
            sw.Reset();


            sw.Start();
            BubbleSort_v2(arrayBubblev2);
            sw.Stop();

            Console.WriteLine("Bubble_v2");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("--------------------------------------------------");

            //-------------------------------------------------------------------------------------------------------------

            counter = 0;
            swaps = 0;
            sw.Reset();


            sw.Start();
            BubbleSort_v3(arrayBubblev3);
            sw.Stop();

            Console.WriteLine("Bubble_v3");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("--------------------------------------------------");

            //-----------------------------------------------------------------------------------------------------------

            counter = 0;
            swaps = 0;
            sw.Reset();


            sw.Start();
            BubbleSort_v4(arrayBubblev4);
            sw.Stop();

            Console.WriteLine("Bubble_v4");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("--------------------------------------------------");

            //-----------------------------------------------------------------------------------------------------------

            counter = 0;
            swaps = 0;
            sw.Reset();


            sw.Start();
            Select_v1(arraySelectv1);
            sw.Stop();

            Console.WriteLine("Select_v1");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("--------------------------------------------------");

            //-----------------------------------------------------------------------------------------------------------

            counter = 0;
            swaps = 0;
            sw.Reset();


            sw.Start();
            Select_v2(arraySelectv2);
            sw.Stop();

            Console.WriteLine("Select_v2");
            Console.WriteLine($"Počet porovnání: {counter}");
            Console.WriteLine($"Počet výměn: {swaps}");
            Console.WriteLine($"Čas: {sw.ElapsedMilliseconds}");
            Console.WriteLine("--------------------------------------------------");
        }

        static void PrintArray(int[] array)
        {

        }

        static void BubbleSort_v1(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    counter++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swaps++;
                    }
                }
            }
        }

        static int[] genArray(int count)
        {
            int[] array = new int[count];


            // tu jeste neco ma byt


            return array;
        }

        static void BubbleSort_v2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    counter++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swaps++;
                    }
                }
            }
        }

        static void BubbleSort_v3(int[] array)
        {
            bool isSorted = true;

            for (int i = 0; i < array.Length; i++)
            {
                isSorted = true;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    counter++;
                    if (array[j] > array[j + 1])
                    {
                        isSorted = false;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swaps++;
                    }
                }
                counter++;
                if (isSorted)
                {
                    break;
                }
            }
        }

        static void BubbleSort_v4(int[] array)
        {

        }

        static void Select_v1(int[] array)
        {


        }

        static void Select_v2(int[] array)
        {


        }


    }
}
