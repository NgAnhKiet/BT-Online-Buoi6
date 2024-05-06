public class Fan
{
    public const int SLOW = 1;
    public const int MEDIUM = 2;
    public const int FAST = 3;

    private int speed;
    private bool on;
    private double radius;
    private string color;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    public bool On
    {
        get { return on; }
        set { on = value; }
    }

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public Fan()
    {
        speed = SLOW;
        on = false;
        radius = 5;
        color = "blue";
    }

    public override string ToString()
    {
        if (on)
        {
            return $"Fan is on\nSpeed: {speed}, Color: {color}, Radius: {radius}";
        }
        else
        {
            return $"Fan is off\nColor: {color}, Radius: {radius}";
        }
    }
}