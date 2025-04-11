using ClassLibrary1;
using static System.Console;

namespace SystemObject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Object obj = new Person()
            {
                PersonName = "Shoaib",
                EmailAdd = "shoaibali.rts@gmail.com"
            };
            // access methods
            WriteLine(obj.Equals(new Person()
            {
                PersonName = "Shoaib",
                EmailAdd = "shoaibali.rts@gmail.com"
            }));
            WriteLine(obj.ToString());
        }
    }
}
