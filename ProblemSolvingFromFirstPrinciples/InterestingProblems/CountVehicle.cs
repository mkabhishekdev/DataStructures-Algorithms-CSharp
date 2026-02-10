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
1. Create a List<List<string>> to declare ParkingGarage
2. Assign the size of the garage given in the problem to ParkingGarage
3. Now you have the list with the exact size needed
4. input string example:["sedan S1 enters","sedan s2 enters","sedan s3 enters","truck t1 enters","sedan s2 leaves",
"truck t2 enters"]
5. sedan = 0.5
   truck = 1
6. List<string> = ParkingSpot
7. int parkingSpotSum = 0;
   int whatHappened = +0.5,-0.5,+1,-1
   parkingSpotSum += whatHappened; //0.5, 1
   based on these, increment the rejectCount variable
8. return the rejectCount
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

            List<List<string>> parkingGarage = new List<List<string>>();
            parkingGarage.size = garageSize;

            int occupiedSpaceSedan = 0.5;
            int occupiedSpaceTruck = 1;
            int rejectCount = 0;
            

            Queue<string> carArrivals = new Queue<string>();
            for(int i = 0; i < inputCars.size; i++)
            {
                carArrivals.Enqueue(inputCars[i]);
            }

            for(int i = 1; i <= parkingGarage.size; i++)
            {
                List<string> spot = parkingGarage[i];  //accessing each parking spot1, spot2 etc. now
                
                string presentCar = carArrivals.Dequeue();
                string[] words = presentCar.Trim().Split(' ');
                string carType = words[0];   // "sedan","truck"
                string carId   = words[1];   // "s1","s2"
                string action  = words[2];   // "enters","leaves"
                int parkingSpotSum = 0;

                while(parkingSpotSum < 1)
                {
                    if(action.Equals("enters"))
                    {
                        if(carType.Equals("sedan"))
                        {
                            parkingSpotSum += 0.5;
                        }
                        else
                        {
                            if(parkingSpotSum == 0)
                            {
                                parkingSpotSum += 1;
                            }
                            else
                            {
                                rejectCount++;
                                break;
                            }
                        }
                    }
                }


            }
        }
    }
}