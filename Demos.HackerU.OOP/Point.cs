namespace Demos.HackerU.OOP
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Display()
        {
            Console.WriteLine($"X:{X},Y:{Y}");
        }

        public void AddX(int value)
        {
            X += value;
        }

        public void AddY(int value)
        {
            Y += value;
        }

        public void Reset()
        {
            X = 0;
            Y = 0;
        }

    }
}