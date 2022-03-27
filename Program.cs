namespace GeniricMethod
{
    public class Programr
    {
        public void compare(string a, string b, string c)
        {
            int res = string.Compare(a,b);
            if (res == 1)
            {
                int res2 = string.Compare(a,c);
                if (res2 == 1)
                {
                    Console.WriteLine($"First value {a} is greater then");
                }
                else
                {
                    Console.WriteLine($"Third value {c} is greater than");
                }
            }
            else
            {
                int res3 = string.Compare(b,c);
                if (res3 == 1)
                {
                    Console.WriteLine($"Second value {b} is greater than ");
                }
                else
                {
                    Console.WriteLine($"Third value {c} is grater than");
                }
            }
            
        }
        static void Main(string[] args)
        {
            Programr programr = new Programr();
            programr.compare("sam","naveen","saranya");
        }
    }
}