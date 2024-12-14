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

            Console.WriteLine("Секретное слово это: " + Program.Shifr1([8, 5, 12, 12, 15, 0, 22, 9, 11, 1]));

            // Задача 7
            Console.WriteLine("Введите индекс и нажмите enter");
            Console.WriteLine("Введите индекс и нажмите enter");
            //string clientindex = Console.ReadLine();
            int ind = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели: " + ind);
            int[] FirstArr = [1, 3, 2, 4, 1, 5];
            Console.WriteLine("Новый массив: " + Program.DeleteElement(ind, FirstArr));
        

        }
        
    
        
        
        
        public static string Shifr1(int[] shifr)
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

        public static int[] DeleteElement(int index, int[] arr){
            int[] array = new int[arr.Length-1];

            //foreach (int i in array) {
            //    if (i != index) { 
            //        array[i] = arr[i];
            //    }
            //    else{ Console.WriteLine(i);  }
            //}


            return array;
        }
}

    //public static int[] DeleteElement(int index; int[] arr){ }
}
