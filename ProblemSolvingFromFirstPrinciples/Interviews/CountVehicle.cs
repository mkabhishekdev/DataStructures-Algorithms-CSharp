using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
Rejections in Parking

Given an ordered list of vehicle activities and number of parking spaces in a parking garage, return the number of
vehicles that were turned away because the garage was full.
A vehicle activity tells the type of car, license plate number, whether the car was entering or leaving.
A vehicle will always park in the first spot availble. If the parking garage does not have space for the car, it will
be turned away at the entrance. This would not be reflected in the ordered list of activities. We have 2 types of
vehicles: A sedan takes 0.5 of a spot and truck takes complete 1 of a full spot.

*/

/*
REFERRED APPROACH:
1. Have a double[] spots of the length equal to garage size, which will keep saving the value like 0,0.5,1 and
   which you can access index and to get the details of the vehicle in that spot
2. Create a Dictionary<string carID, (int spotIndex, double size)> parkedCars
3. Iterate through a for loop & work through all the condition  
*/

namespace ProblemSolvingFromFirstPrinciples.InterestingProblems
{
    public class CountVehicle
    {
        public int CountVehicleImpl(string[] inputCars, int garageSize)
        {
            if(garageSize == 0)
            {
                return 0;
            }
           
            double[] spots = new double[garageSize];
            Dictionary<string, (int spotIndex, double size)> parkedCars = new Dictionary<string, (int spotIndex, double size)>();

            int rejectCount = 0;

            foreach(var presentCar in inputCars)
            {
                string[] words = presentCar.Trim().Split(' ');
                string carType = words[0];   // "sedan","truck"
                string carId   = words[1];   // "s1","s2"
                string action  = words[2];   // "enters","leaves"

                if(action.Equals("enters"))
                {
                    bool parked = false;

                    for(int i = 0; i < garageSize; i++)
                    {
                        if(carType == "truck")
                        {
                            if(spots[i] == 0)
                            {
                                spots[i] = 1;
                                parkedCars[carId] = (i,1);
                                parked = true;
                                break;
                            }
                        }
                        else  //sedan
                        {
                            if(spots[i] <= 0.5)
                            {
                                spots[i] += 0.5;
                                parkedCars[carId] = (i,0.5);
                                parked = true;
                                break;
                            }
                        }
                    }  
                    if(!parked)
                    {
                        rejectCount++;
                    }    
                }
                else   // if vehicle leaves
                {
                    if(parkedCars.ContainsKey(carId))
                    {
                        var info = parkedCars[carId]; //this will pick the value from Dictionary
                        spots[info.spotIndex] -= info.size;
                        parkedCars.Remove(carId);  
                    }
                    
                }
            }
            return rejectCount;
        }
    }
}


  // If all test cases not clearing or You did not arrive at the solution on own, PRACTICE DEBUGGING MUST
        /* FAILED APPROACH & WHY?(you used wrong data structure 'queue' and your while condition was wrong)
1. Have created two queues ‘carArrivals’ and ‘carParkedOrder’ to keep track of the cars
2. Than I use a for loop to trim ,split each car
3. I have a parkingspotsum variable based on its satisfaction I keep checking within the while loop
   But I think I need to improve some logic here since the question involves very specific vehicle spot movement
4. I return the rejectCount
        */ 
        /* CODE:
         public int CountVehicleImpl(string[] inputCars, int garageSize)
        {
            if(garageSize == 0)
            {
                return 0;
            }
           
            double occupiedSpaceSedan = 0.5;
            int occupiedSpaceTruck = 1;
            int rejectCount = 0;
            double parkingSpotSum = 0;

            Queue<string> carArrivals = new Queue<string>();
            for(int i = 0; i < inputCars.Length; i++)
            {
                carArrivals.Enqueue(inputCars[i]);
            }
            
            Queue<string> carParkedOrder = new Queue<string>();

            for(int i = 1; i <= inputCars.Length; i++)
            {
                
                string presentCar = carArrivals.Dequeue();
                string[] words = presentCar.Trim().Split(' ');
                string carType = words[0];   // "sedan","truck"
                string carId   = words[1];   // "s1","s2"
                string action  = words[2];   // "enters","leaves"


                while(parkingSpotSum < 1)
                {
                    if(action.Equals("enters"))
                    {
                        if(carType.Equals("sedan"))
                        {
                            parkingSpotSum += 0.5;
                            carParkedOrder.Enqueue(carId);
                            
                        }
                        else
                        {
                            if(parkingSpotSum == 0)
                            {
                                parkingSpotSum += 1;
                                carParkedOrder.Enqueue(carId);
                              
                            }
                            else
                            {
                                rejectCount++;
                               
                            }
                        }
                    }
                    if(action.Equals("leaves"))
                    {
                        if(carType.Equals("sedan") && carParkedOrder.Contains(carId))
                        {
                            parkingSpotSum -= 0.5;
                          
                        }
                    }
                    if(parkingSpotSum == 1)
                    {
                        parkingSpotSum = 0;
                    }
                    break;
                }
            }
            return rejectCount;
        }
    }

        */