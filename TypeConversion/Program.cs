using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1;
            //byte b = (byte) i;
            //Console.WriteLine(b);

            try
            {
                //var number = "1234";
                //int i = (int) number; use convert class
                //byte b = Convert.ToByte(number);
                //Console.WriteLine(b);  

                string str = "true";
                bool b = Convert.ToBoolean(str);  
                Console.WriteLine(b);
            }
            catch (System.Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");     
            }

        }
    }
}
