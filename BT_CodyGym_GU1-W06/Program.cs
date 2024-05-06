using static Shape;

internal class Program
{
    private static void Main(string[] args)
    {
        //Thực hành lớp hình chữ nhật
        Console.WriteLine("Enter the width:");
        double width = Double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height:");
        double height = Double.Parse(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine("Your Rectangle \n" + rectangle.Display());
        Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
        Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());

        //Thực hành xây dựng class Animal  
        Cat cat = new Cat("20kg", "1.5", "kitty");
        cat.PrintInfo();

        //Thực hành Static method
        Student.Change();
        Student s1 = new Student(111, "Hoang");
        Student s2 = new Student(222, "Khanh");
        Student s3 = new Student(333, "Nam");
        s1.Display();
        s2.Display();
        s3.Display();

        //Bài tập xây dựng lớp Fan
        Fan fan1 = new Fan();
        fan1.Speed = Fan.FAST;
        fan1.Radius = 10;
        fan1.Color = "yellow";
        fan1.On = true;

        Fan fan2 = new Fan();
        fan2.Speed = Fan.MEDIUM;
        fan2.Radius = 5;
        fan2.Color = "blue";
        fan2.On = false;

        Console.WriteLine("Fan 1:");
        Console.WriteLine(fan1.ToString());
        Console.WriteLine();

        Console.WriteLine("Fan 2:");
        Console.WriteLine(fan2.ToString());

        //Bài tập xây dựng lớp Stopwatch

        //Thực hành các đối tượng hình học
        Shape shape = new Shape();
        Console.WriteLine(shape);
        shape = new Shape("red", false);
        Console.WriteLine(shape);
        Console.WriteLine("Hello World!");
        Circle circle = new Circle();
        Console.WriteLine(circle);
        circle = new Circle(3.5);
        Console.WriteLine(circle);
        circle = new Circle(3.5, "indigo", false);
        Console.WriteLine(circle);

        //Bài tập xây dựng lớp Point 2D và 3D
        Point2D point2D= new Point2D(9,12);
        System.Console.WriteLine(point2D);
        point2D = new Point2D(7,10);
        System.Console.WriteLine(point2D);
        Point3D point3D= new Point3D(9,12,15);
        System.Console.WriteLine(point3D);
        point3D = new Point3D(9,12,17);
        System.Console.WriteLine(point3D);
    }

}