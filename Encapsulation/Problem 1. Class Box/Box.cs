using System;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {

        this.Length = length;
        this.Width = width;
        this.Height = height;
    }

    public double Length
    {
        private get
        {
            return this.length;
        }
        set
        {
            if (value <= 0)
            {
                throw new Exception("Length cannot be zero or negative.");
            }
            this.length = value;
        }
    }

    public double Width
    {
        get => this.width;
         set
        {
            if (value <= 0)
            {
                throw new Exception("Width cannot be zero or negative.");
            }

            this.width = value;
        }
    }

    public double Height
    {
        get
        {
            return this.height;
        }
        private set
        {
            if (value <= 0)
            {
                throw new Exception("Height cannot be zero or negative.");

            }
            this.height = value;
        }
    }

    public double SurfaceArea()
    {
        double surfaceArea = ((length * height) + (width * height) + (length * width)) * 2;
        return surfaceArea;
    }
    public double LateralSurfaceArea()
    {
        double lateralSurfaceArea = ((length * height) + (width * height)) * 2;
        return lateralSurfaceArea;
    }
    public double Volume()
    {
        double volume = length * width * height;
        return volume;
    }
}