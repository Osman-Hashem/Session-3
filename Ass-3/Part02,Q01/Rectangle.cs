namespace Ass_3.Part02_Q01
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
        double IShape.Area { get; set; }

        public double Area => Length * Width;


        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Length = {Length} , Width = {Width} :\nAnd Area = {Area}");
        }
    }
}

