using System;

public class Program
{
    public static void Main(string[] args)
    {
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());



        try
        {
            Box box = new Box(length, width, height);
            //box.Width = -3;
            Console.WriteLine(box.Width);
            
            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");

 
        }
        
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }  

    }
}