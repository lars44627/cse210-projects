using System;

public class Shape
{
   protected string color;

   public Shape(string color)
    {
        this.color = color;
    }

    public string GetColor()
    {
        return color;
    }

    public void SetColor(string newColor)
    {
        color = newColor;
    }

    public abstract double GetArea();
}