namespace GeniricMethod
{
    public class Programr
    {
        public void compare(int a, int b, int c)
        {
            int res = a.CompareTo(b);
            if (res == 1)
            {
                int res2 = a.CompareTo(c);
                if (res2 == 1)
                {
                    Console.WriteLine("First value {0} is greater then",+a);
                }
                else
                {
                    Console.WriteLine("Third value {0} is greater than",+c);
                }
            }
            else
            {
                int res3 = b.CompareTo(c);
                if (res3 == 1)
                {
                    Console.WriteLine("Second value {0} is greater than ",+b);
                }
                else
                {
                    Console.WriteLine("Third value {0} is grater than",+c);
                }
            }
        }
        static void Main(string[] args)
        {
            Programr programr = new Programr();
            programr.compare(5,10,15);
        }
    }
}