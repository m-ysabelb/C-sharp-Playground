using System;

namespace Exercise2 {
    class whileLoop {
        public static void Main(string[] args) {
                //Define three variables for the LaunchCode shuttle - one for the starting fuel level, another for the number of astronauts aboard, and the third for the altitude the shuttle reaches.
                
                int fuelLvl;
                int astronautNum;
                int altitude = 0;   //distance in km

    /*Exercise #3: Construct while loops to do the following:
        a. Query the user for the starting fuel level. Validate that the user enters a positive, integer value greater than 5000 but less than 30000. */
        
            Console.WriteLine("R O C K E T  L A U N C H  G A M E");
            Console.WriteLine("");
            
            Console.Write("Enter your fuel level (5000 - 30000 for a good blast off): ");
            fuelLvl = Convert.ToInt32(Console.ReadLine());
            
            while (fuelLvl < 5000 || fuelLvl > 30000) {
                Console.Write("Enter a VALID fuel level (5000 - 30000 for a good blast off): ");
                fuelLvl = Convert.ToInt32(Console.ReadLine());
                }
            
            Console.WriteLine("");
            Console.WriteLine("You're good to go!");
            Console.WriteLine("");

        //b. Use a second loop to query the user for the number of astronauts (up to a maximum of 7). Validate the entry.
            
            Console.Write("Enter the no. of astronauts (1-7 only): ");
            astronautNum = Convert.ToInt32(Console.ReadLine());
            
            while (astronautNum < 1 || astronautNum > 7) {
                Console.Write("Enter a VALID number (1-7 only): ");
                astronautNum = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("");
            Console.WriteLine("The rocket is ready.");
            Console.WriteLine("");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("");
            Console.WriteLine("");
  
        //c. Use a final loop to monitor the fuel status and the altitude of the shuttle. Each iteration, decrease the fuel level by 100 units for each astronaut aboard. Also, increase the altitude by 50 kilometers.

            
            Console.WriteLine("Initial fuel level: "  + fuelLvl + ", Initial altitude: "+ altitude);
            Console.WriteLine("");
            
            while (fuelLvl-100*astronautNum >= 0) {
                altitude += 50;
                fuelLvl -= 100*astronautNum;
                Console.WriteLine("New fuel level: " + fuelLvl + ", New altitude: "+ altitude);
            }
            
            
            Console.WriteLine("");
            
    /*Exercise #4: Output the result with the phrase, “The shuttle gained an altitude of ___ km.”

        If the altitude is 2000 km or higher, add “Orbit achieved!” Otherwise add, “Failed to reach orbit.”*/

            Console.WriteLine("The shuttle gained an altitude of " + altitude + " km.");

            if (altitude >= 2000) {
                Console.WriteLine("Orbit achieved!");
            }
            
            else {
                Console.WriteLine("Failed to reach orbit.");
            }
              
        }
    }
}
