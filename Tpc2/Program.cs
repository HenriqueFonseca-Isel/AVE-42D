using System;
using System.Reflection;


namespace Tpc2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try{
                 Assembly asm =  Assembly.LoadFrom(@"C:\Users\user\Desktop\Isel\AVE\Tpc2\RestSharp.dll");

                
                foreach(Type a in asm.GetTypes() ){
                      Console.WriteLine(a);
                     foreach( MethodInfo c in a.GetMethods())
                        Console.WriteLine(c);}
            
            }catch(Exception b){
                 Console.WriteLine("Holla");
            }
                


            Console.WriteLine("Hello World!");

        

        }
    }
}
