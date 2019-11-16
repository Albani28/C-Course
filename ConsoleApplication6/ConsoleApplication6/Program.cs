namespace System
{
    class SwitchCase
    {
        public static void Main(string[] args)
        {
            {
                char c;
                int a;
                int b;
                Console.WriteLine("Vendos vleren e numrit te pare");
                a=Int32.Parse(Console.ReadLine());
                Console.WriteLine("Vendos vleren e numrit te dyte");
                b=Int32.Parse(Console.ReadLine());
 
                Console.WriteLine("Vendos veprimin");
                c = Convert.ToChar(Console.ReadLine());

                switch (c)
                {
                    case '+':
                        Console.WriteLine(a+b);
                        break;
                    case '/':
                        Console.WriteLine(a/b);
                        break;
                    case '-':
                        Console.WriteLine(a-b);
                        break;
                    case '*':
                        Console.WriteLine(a*b);
                        break;
                    default:
                        Console.WriteLine("Veprimi qe keni vendosur eshte i pasakte");
                        break;
                }
            }
        }
    }
}