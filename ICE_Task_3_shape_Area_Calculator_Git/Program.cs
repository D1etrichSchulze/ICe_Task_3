namespace ICE_Task_3_shape_Area_Calculator_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(12.3, 15.7);
            r.Display();

            Circle c = new Circle(4);
            c.Display();

            Console.ReadKey();

            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World Again");
        }
    }
}
