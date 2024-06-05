// 9.9.1 For Loop Practice
// Source Test below
// https://education.launchcode.org/intro-to-programming-csharp/chapters/loops/exercises.html

using System;

public class ForLoopSolution
{
    public static void Main(string[] args)
    {
    //a. Print the numbers 0 - 20, one number per line.
        /*
        for (int i = 0; i < 21; i++) {
            Console.WriteLine(i);
        }
        */
        
        Console.WriteLine("");
        
    //b. Print only the ODD values from 3 - 29, one number per line.
        /*
        for (int i = 3; i < 30; i++) {
            int value = i%2;
            
            if (value == 1) {
                Console.WriteLine(i);
            }
            else {
                continue;
            }
        }
        */
        Console.WriteLine("");
        
    //c. Print the EVEN numbers 12 to -14 in descending order, one number per line.
        /*
       for (int i = 12; i > -15; i--) {
           int value = i%2;
           
           if (value == 0) {
               Console.WriteLine(i);
           }
           else {
               continue;
           }
       }
       */
        Console.WriteLine("");
    
    //d. Challenge - Print the numbers 50 - 20 in descending order, but only if the numbers are multiples of 3. (Your code should work even if you replace 50 or 20 with other numbers.  Remember your operators!).
        /*
        for (int i = 50; i > 19; i--) {
            int checkPt = i%3;
            
            if (checkPt == 0) {
                Console.WriteLine(i);
            }
            
            else {
                continue;
            }
        }
        */
        Console.WriteLine("");


    //Exercise #2: ------------------------------
    //Initialize two variables to hold the string “LaunchCode” and the array {1,5,-9,234, 42}.
    string varOne = "LaunchCode";
    int[] varTwo = {1, 5, -9, 234, 42};

    //Construct ``for`` loops to accomplish the following tasks:
     // a. Print each element of the array to a new line.
    for (int i = 0; i < varTwo.Length; i++) {
        Console.WriteLine(varTwo[i]);   
    }
    
    Console.WriteLine("");
    
      //b. Print each character of the string - in reverse order - to a new line.
        //Console.WriteLine(varOne.Length);
    
    for (int j = 0; j < varOne.Length; j++) {
        Console.WriteLine(varOne[9-j]);
    }

	Console.WriteLine("");

    }
}
