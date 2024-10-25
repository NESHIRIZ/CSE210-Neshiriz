public class Rectangle : Shape
{
    private float length;
    private float width;

    public Rectangle(string color, float length, float width) : base(color)
    {
        this.length = length;
        this.width = width;
    }

    public override float GetArea()
    {
        return length * width;
    }
}