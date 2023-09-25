namespace Lab_2._1
{

    class Rectangle
    {
        private double a;
        private double b;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        public bool Correct()
        {
            return a > 0 && b > 0;
        }

        public double Area()
        {
            return a * b;
        }

        public double Perimeter()
        {
            return 2 * (a + b);
        }

        public void Print()
        {
            Console.WriteLine($"Сторона A: {a}");
            Console.WriteLine($"Сторона B: {b}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Rectangle rect = new Rectangle(); 

                Console.Write("Введiть значення сторони A: ");
                rect.A = double.Parse(Console.ReadLine());

                Console.Write("Введiть значення сторони B: ");
                rect.B = double.Parse(Console.ReadLine());

                Console.WriteLine("Значення полiв прямокутника:");
                rect.Print();

                if (rect.Correct())
                {
                    Console.WriteLine($"Площа прямокутника: {rect.Area()}");
                    Console.WriteLine($"Периметр прямокутника: {rect.Perimeter()}");
                }
                else
                {
                    Console.WriteLine("Такий прямокутник не iснує (одна або обидвi сторони менше або рiвнi нулю).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}