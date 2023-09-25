namespace lab1ex1
{
    class Program
    {
        /*
         Scrieti o functie care va determina daca un numar este sau nu palindrom.
         */
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            int left = 0;
            int right = input.Length - 1;
            bool palindrom = true;

            while(left < right)
            {
                if (input[left] != input[right])
                {
                    palindrom = false; 
                    break;
                }
                left++;
                right--;
            }

            if (palindrom)
            {
                Console.WriteLine("este palindrom: !");
            }
            else
            {
                Console.WriteLine("Nu este palindrom!");
            }
            
            Console.WriteLine("Bye!");
            
        }
    }
}