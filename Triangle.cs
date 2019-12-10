using System;
using System.Collections.Generic;

class Triangle {

    public int Side1;
    public int Side2;
    public int side3;

    public Triangle(int side1, int side2, int side3)
    {
        this.Side1 = side1;
        this.Side2 = side2;
        this.side3 = side3;
    }

    public bool TriangleConfirmation(int side1, int side2, int side3)
    {
        if (((side1 + side2) > side3) || ((side2 + side3) > side1) || ((side3 + side1) > side2))
        {
            return true;
        }
        return false;
    }

    public string typeOfTriangle(int side1, int side2, int side3)
    {
        if (side1 == side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if (side1 != side2 && side2 != side3)
        {
            return "Scalene";
        }
        else 
        {
            return "Isosceles";
        }
    }

}

class InterfaceProgramm
{
    public static void Main() 
    {

     Console.WriteLine("Please Enter a length for side 1: ");
     int side1Input = int.Parse(Console.ReadLine());
     
     Console.WriteLine("Please enter a length for side 2: ");
     int side2Input = int.Parse(Console.ReadLine());

     Console.WriteLine("Please enter a length for side 3:");
     int side3Input = int.Parse(Console.ReadLine());

      Triangle triangle1 = new Triangle(3, 3, 3);
      Triangle triangle2 = new Triangle(2, 2, 3);  


    bool results = Triangle.TriangleConfirmation(triangle1);
    Console.WriteLine(results);
    }


}


// ((side1 == side2 && side2 != side3) || (side1 != side2 && side2 == side3) ||(side1 == side3 && side2 != side3))