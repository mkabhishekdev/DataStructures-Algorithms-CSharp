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

Parking garage has 2 spots say input
*/

/*
APPROACH:

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
}