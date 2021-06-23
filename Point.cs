namespace OverloadingOperators
{
  public class Point
  {
    public int X { get; set; }
    public int Y { get; set; }
    public Point(int xPos, int yPos)
    {
      X = xPos;
      Y = yPos;
    }
    public override string ToString() => $"[{this.X}, {this.Y}]";

    public static Point operator +(Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
    public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);
    public static Point operator +(Point p1, int number) => new Point(p1.X + number, p1.Y + number);
    public static Point operator +(int number, Point p1) => new Point(p1.X + number, p1.Y + number);
    public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);


    public override bool Equals(object o) => o.ToString() == this.ToString();
    public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
    public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);

  }
}