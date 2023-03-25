namespace example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Interface1 test = new Class1();

            Console.WriteLine(test.Meth(9));

            Console.WriteLine(test.Meth(6));
            Console.WriteLine(test.Meth1(6));
            Console.WriteLine(class1.Meth(6));


        }
    }
}