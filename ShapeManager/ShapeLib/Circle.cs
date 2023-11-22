namespace ShapeLib
{
    public class Circle :Paint,IShape
    {
        public int radius;

        public string Draw()
        {
            return $"A circle of length {this.radius} has been drawn.\n";
        }

        public string GetDetails()
        {
            return $"Circle's Radius: {this.radius}\n";
        }
        public override string CalculateArea()
        {
            return $"Area of Circle is: {3.14 * radius * radius}\n\n";
        }
    }
}