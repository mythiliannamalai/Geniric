namespace GeniricMethod
{
    public class Programr
    {
        public void compare(float a, float b, float c)
        {
            float res = a.CompareTo(b);
            if (res == 1)
            {
                float res2 = a.CompareTo(c);
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
                float res3 = b.CompareTo(c);
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
            programr.compare(15.1f ,20.1f,10.2f);
        }
    }
}