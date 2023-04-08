using System.Globalization;

namespace Takrorolash_Massive_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter massive lenth: ");
            int uzunlik=int.Parse(Console.ReadLine());
            int[]arr=new int[uzunlik];
            FillMassive(arr,uzunlik);
            Console.WriteLine();
            Dublicate(arr);
        }
        public static int FillMassive(int[]arr,int uzunlik)
        {
            Random random = new Random();   
            for(int i=0;i<uzunlik;i++)
            {
                arr[i]=random.Next(10,20);
                Console.Write(" "+arr[i]);
            }
            return uzunlik;
        }

        public static void Dublicate(int[] arr)
        {
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(" "+arr[i]);
            }
            Console.WriteLine( );
            
            for(int i = 0; i < arr.Length; i++)
            {
                int countr = 1;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        countr++;
                    }
                    else break;
                    
                }
                if(countr > 1 )
                {
                    Console.WriteLine(arr[i]+" -> "+countr);
                }
                i+=(countr-1);
            }
        }

    }
}