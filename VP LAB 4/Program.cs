using System;
class Lab5
{

    static void Main(string[] args)
    {
        /* double a = 98, b = 0;
         double result = 0;
         try
         {
             result = SafeDivision(a, b);
             Console.WriteLine($"{a} divided by {b}={result}");
         }
         catch (DivideByZeroException)
         {
             Console.WriteLine("An Attempt Divided By zero.");
         }
        */
        TestCatch2();
    }
    static void TestCatch2()
    {
        System.IO.StreamWriter sw=null ;
        try
        {
            sw = new System.IO.StreamWriter(@"C:\test\test.txt");
            sw.WriteLine("Hello Whats up dude");
        }
        catch (System.IO.FileNotFoundException ex)
        {
            System.Console.WriteLine(ex.ToString());

        }
        catch(System.IO.IOException ex)
        { System.Console.WriteLine(ex.ToString());}
        finally
        {
            sw.Close();
        }
    }
    /*static double SafeDivision(double k, double l)
    {
        if (l == 0)
            throw new System.DivideByZeroException();
        return k / l;
    }*/
}