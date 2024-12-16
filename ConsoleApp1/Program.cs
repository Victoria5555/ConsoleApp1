using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Задача 1
            // Попытка прикрутить ввод любого слова
            //Console.WriteLine("Введите шифр цифрами через запятую и нажмите enter");
            //string clientstring;
            //clientstring = Console.ReadLine();
            //Console.WriteLine("Вы ввели: "+clientstring);
            //int[] clientarr = [];

            Console.WriteLine("Секретное слово это: " + Program.Z1_Shifr1([8, 5, 12, 12, 15, 0, 22, 9, 11, 1]));

            //Console.WriteLine("RESULTARR = " + Program.Z8_2(11, [1, 2, 4, 7, 9, 11]));
            
            // int[] array_for_z8 = [1, 2, 4, 7, 9, 11]; // 4,1
             int[] array_for_z8 = [1, 2, 4, 4, 7, 7, 9, 11]; // 6,1
            // int[] array_for_z8 = [1, 2, 9, 11]; // 2,1
            // int[] array_for_z8 = [1, 3, 4, 9, 11]; // нет решения
            int X_z8 = 11;

            int[] result_z8_2 = Program.Z8_2(X_z8, array_for_z8);

            //foreach (int t in result_z8_2) {
            //    Console.WriteLine(
            //        //"t="+t+": " + 
            //        result_z8_2[t]); 
            //}

            for (int k = 0; k < result_z8_2.Length; k++) { Console.WriteLine(result_z8_2[k]); }

            Console.WriteLine("Задача 9. randomarray: ");
            int L = 10;
            int MIN = 0;
            int MAX = 100;

            //Console.WriteLine("Введите L: "); 
           // L=Console.ReadLine();

            int[] randarr = Program.Z9(L, MIN, MAX);
            
            //for (int j = 0; j < randarr.Length; j++) { Console.WriteLine(randarr[j]); }

            /*// Задача 7
            Console.WriteLine("Введите индекс и нажмите enter");
            Console.WriteLine("Введите индекс и нажмите enter");
            //string clientindex = Console.ReadLine();
            int ind = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + ind);
            int[] FirstArr = [1, 3, 2, 4, 1, 5];
            Console.WriteLine("Новый массив: " + Program.DeleteElement(ind, FirstArr));
        */

        }
        
        public static int[] Z9(int L, int MIN, int MAX)
        {
            int l = L;
            int min = MIN;
            int max = MAX;

            int[] randomarray = new int[l];

            int currmax = max / l;
            int currmin = min;
            Random rnd = new Random(currmax);

            int rint = min;
            // int rint = rnd.Next(currmin,currmax);

            Console.WriteLine("rint = " + rint);

            for (int i = 0; i < l; i++)
            {

                rint = rnd.Next(currmin, currmax);


                if (randomarray[i] < rint)
                {
                    randomarray[i] = rint;
                    currmin = rint;
                    currmax = max / (l - i);
                    Console.WriteLine("i=" + i + " rint=" + rint + " currmin=" + currmin + " currmax=" + currmax);
                }
            }

            // вывод массива 
            //foreach (int t in randomarray){
            // Console.WriteLine(randomarray[t]);
            // }

            for (int k = 0; k < l; k++)
            {
                Console.WriteLine("randomarray["+k+"]"+"="+randomarray[k]);
            }


            return randomarray;
        }






    
        public static int[] Z8 (int X, int[]Arr)
        {
            int[] arr = Arr;
            int x = X;

            int[] resultarr = new int[5];
            int r = 0;

            for (int i = 0; i < arr.Length; i++) 
            {
                Console.WriteLine("i=" + i);
                for (int j = 0; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];
                    Console.WriteLine("sum =" + sum);

                    if (sum == x)
                    {
                        Console.WriteLine("resultarr[" + r + "]=" + i);
                        resultarr[r] = i; 
                        resultarr[r + 1] = j;
                        r++;
                    }

                }
            }


            return resultarr;
        }

        public static int[] Z8_2(int X, int[] Arr)
        {
            int[] arr = Arr;
            int x = X;
            
            int[] arrcopy = arr;

            int[] resultarr = new int[arr.Length];
            int r = 0;
            //int j = 1;
            int sum = 0;

            while (sum < x)
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    for (int j = 0; j < arrcopy.Length; j++)
                    {
                        sum = arr[i] + arrcopy[j];
                        if (sum > x) { break; }
                        Console.WriteLine("sum ("+ arr[i] + "+"+arrcopy[j]+")= " + sum);
                        if (sum == x) { 
                            resultarr[r] = i; 
                            resultarr[r + 1] = j;
                            Console.WriteLine("_________" + r);
                            // r = r+2;

                            break;
                            Console.WriteLine("r=" + r);
                        }
                    }
                }

            }


            return resultarr;
        }





        public static string Z1_Shifr1(int[] shifr)
        {
            // Задача
            Console.WriteLine("1. Задача с числовым шифром\r\n У тебя есть массив целых чисел, который является шифром. \r\n Каждое число в массиве — это позиция в алфавите (от 1 до 26). \r\n Твоя задача — преобразовать массив в строку, которая представляет собой слово, \r\n  где каждое число соответствует букве алфавита.");
            // загружаем алфавит
            string[] alfabet1 = ["_", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p","q","r","s","t","u","v","w","x","y","z"]; 
            
            int[] secretword = shifr;
            string[] word = new string[secretword.Length];
            string allword = "";

            for (int i = 0; i < (secretword.Length); i++)
            {
                word[i] = alfabet1[(int)secretword[i]]; 
                allword = allword + word[i];
                Console.WriteLine("Буква:" + word[i]);
            }//Console.WriteLine("Secret word:" + allword);
            return allword;
        }

        /*метод для задачи 7
         * public static int[] DeleteElement(int index, int[] arr){
            int[] array = new int[arr.Length-1];

            //foreach (int i in array) {
            //    if (i != index) { 
            //        array[i] = arr[i];
            //    }
            //    else{ Console.WriteLine(i);  }
            //}


            return array;
        }*/
}
    //для задачи 7
    //public static int[] DeleteElement(int index; int[] arr){ }
}
