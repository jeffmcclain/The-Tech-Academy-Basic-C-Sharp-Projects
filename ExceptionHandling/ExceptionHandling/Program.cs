using System;



class Program
{
    static void Main(string[] args)
    {

        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second numeber.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        }
        catch (FormatException ex) // catches input format errors
        {
            Console.WriteLine("Please type a whole number"); // prints custom error message
            return; // stops execution of method
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero"); //This prints the custom error message
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // prints error message
        }
        finally // this executes regardless of a 'catch'
        {
            Console.ReadLine();
        }
        

        Console.ReadLine();
    }
}

