using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessNum
{
    internal class GuessApp
    {
        int randomNum = 0;
        bool guessWrong = true;

        public void Run()
        {
            Random rand = new Random();
            randomNum = rand.Next(0, 100);

           
            while (guessWrong)
            {
            
            Console.WriteLine("Guess The Number");   
            Console.WriteLine("Please type a number from 1-100!");
            int userInput = Convert.ToInt32(Console.ReadLine());
            _TheNum(userInput);
            
            }
           

        }
        
        void _TheNum(int userInput)
        {            

            if (userInput == randomNum)
            {
                
                Console.WriteLine("You have gusssed the correct number");
                guessWrong = false;
                _ContinueChoice();
                

            }  
            else if (userInput > randomNum)
            {  
                Console.WriteLine("Number is too high!");

            }
            else if (userInput < randomNum)
            {
                Console.WriteLine("Number is too low!");
                
            }
              
        }
       
        void _ContinueChoice()
        {
            Console.WriteLine("Restart game?");
            Console.WriteLine("1. Restart");
            Console.WriteLine("2. Exit");
            var menuChoice = Console.ReadLine();
            switch(menuChoice)
            {
                case "1":
                    Run();
                    break;
                case "2":
                    return;
                    break;
              
            }

        }















    }
}   

    
        









