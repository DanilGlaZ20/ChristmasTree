using System;
using System.ComponentModel.DataAnnotations;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {

            ChristmasTree<int> fir = new ChristmasTree<int>(1);
          fir.DisplayBFS();
         
        }

    
    }
}