
    using System;

namespace ITaplets
{

    class Client
    {
        public void Main()
        {
            Console.WriteLine("Testing client code with Lenovo factory");
            CMethod(new Lenovo());
            Console.WriteLine();

            Console.WriteLine("Testing client code with Apple factory");
            CMethod(new Apple());
        }

        public void CMethod(ITaplets factory)
        {
            var TapletsPencil = factory.PencilShape();
            var TapletsKeyBoard = factory.KeyBoardSize();


            Console.WriteLine(TapletsPencil.PencilB());
            Console.WriteLine(TapletsKeyBoard.KeyBoardB());

        }
    }

      class MainTablets { 
    
       public static void Main(string[] args) { 
       new Client().Main();
        } } }



