using System;
namespace exam {
    class program {
        static void Main(string[] args) {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            bool keepgoing = true;
            
            int x = 5;
            int y = 2;
            int z = 3;
            
            
            while(keepgoing = true){
            if (c = "End") {
                keepgoing = false;
            } else {
            switch (c) {
                case "Breakfast Set":
                if(b > 11){
                    Console.WriteLine("Sorry your order is not available");
                    break;
                } else if(x > 0) {
                        x--;
                } else if (x == 0){
                    Console.WriteLine("Sorry your order is out of stock");
                    break;
                } else {
                    
                }
                break;

                case "Weekend Set":
                if (a != 6 || a != 7){
                    Console.WriteLine("Sorry your order is not available");
                    break;
                } else if (y > 0) {
                    y--;
                } else if (y == 0){
                    Console.WriteLine("Sorry your order is out of stock");
                    break;
                } else {
            
                }
                break;

                case "Coffee" :
                if (z > 0){
                    z--;
                    break;
                    
                } else if (z == 0) {
                    Console.WriteLine("Sorry your order is out of stock");
                    break;
                } else {

                }
                break;

                case "End":
                keepgoing = false;
                break;

                default:
                    Console.WriteLine("Please enter a valid menu");
                    break;
            }
            } 
            }
        }
    }
}