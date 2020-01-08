using System;
using System.Collections.Generic;

class Triangle {

    public int Side1;
    public int Side2;
    public int Side3;

    public Triangle(int side1, int side2, int side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.Side3 = side3;
    }

    public bool TriangleConfirmation()
    {
        if (((this.Side1 + this.Side2) > this.Side3) || ((this.Side2 + this.Side3) > this.Side1) || ((this.Side3 + this.Side1) > this.Side2))
        {
            return true;
        }
        return false;
    }

    public string typeOfTriangle()
    {
       
        if (this.Side1 == this.Side2 && this.Side2 == this.Side3)
        {
            return "Equilateral";
        }
        else if (this.Side1 != this.Side2 && this.Side2 != this.Side3)
        {
            return "Scalene";
        }
        else 
        {
            return "Isosceles";
        }   
    }

    public string printObjectProperties()
    {
        string trianlgeSides = "Side One: " + this.Side1 + " Side Two: " + this.Side2 + " Side Three: " + this.Side3;
        return trianlgeSides; 
    }

}

class InterfaceProgramm
{
    public static void Main() 
    {
        Console.WriteLine("Please enter a length for side 1: ");
        int side1Input = int.Parse(Console.ReadLine());
     
        Console.WriteLine("Please enter a length for side 2: ");
        int side2Input = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a length for side 3:");
        int side3Input = int.Parse(Console.ReadLine());

        Triangle triangle1 = new Triangle(3, 3, 3);
        Triangle triangle2 = new Triangle(2, 2, 3); 
        Triangle triangle3 = new Triangle(side1Input, side2Input, side3Input);

        Console.WriteLine(triangle2.TriangleConfirmation());
        Console.WriteLine(triangle2.printObjectProperties());
        Console.WriteLine(triangle2.typeOfTriangle());
        
        bool results = triangle3.TriangleConfirmation();

        if (results)
        {
           Console.WriteLine(triangle3.printObjectProperties());
           string triangleTypeVariable = triangle3.typeOfTriangle();
           Console.WriteLine(triangleTypeVariable);
        }
        else {
           Console.WriteLine("The side lengths you entered do not make a triangle!!!");
       }
    }
    
}

