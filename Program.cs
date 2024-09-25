namespace Lab_5___Grunderna_OOP
{
    class Circle
    {
        int _radius;
        public Circle(int radius)
        {
            this._radius = radius;
        }

        public double GetArea()
        {
            return _radius * _radius * Math.PI;
        }

        public void ShowAreaInformation()
        {
            Console.WriteLine($"Arean för cirkeln med raden {_radius}cm, är: {GetArea():F2}");
        }
    }

    class Triangel
    {
        public int _Base;
        public int _hight;

        public Triangel(int bas, int hight)
        {
            this._Base = bas;
            this._hight = hight;
        }

        public float GetTriangelArea()
        {
            return (_Base * _Base) / 2;
        }

        public void triangelInfo()
        {
            Console.WriteLine($"Arean för triangeln med basen {_Base}cm och höjden {_hight}cm är: {GetTriangelArea()}cm.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Area räknare för cirkeln och triangeln!");
            Console.WriteLine("Vi börjar med cirkeln!. Vad vill du att radien ska vara? Skriv i tal!");
            int radius = Convert.ToInt32(Console.ReadLine());
            Circle cirkel = new Circle(radius);

            cirkel.ShowAreaInformation();
            Console.WriteLine();

            Console.WriteLine("I och med att det i uppgiften står att jag ska räkna ut arean för cirkeln med radie 5 och 6 så kommer det här nu också.");
            Console.WriteLine();

            Circle cirkelOne = new Circle(5);
            Circle cirkelTwo = new Circle(6);
            cirkelOne.ShowAreaInformation();
            cirkelTwo.ShowAreaInformation();
            Console.WriteLine();

            Console.WriteLine("Nu övergår vi till Triangelns Area! Ska kolla vad uppgiften säger om den!");
            Console.WriteLine("Nu vet jag! Du ska välja basen och höjden för triangeln!");
            Console.WriteLine("Vad vill du att basen på triangeln ska vara?");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Vad vill du att höjden på triangeln ska vara?");
            int hight = Convert.ToInt32(Console.ReadLine());
            Triangel triangel = new Triangel(bas, hight);
            triangel.triangelInfo();


        }
    }
}
