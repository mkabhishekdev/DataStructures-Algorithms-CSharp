using System;
using ProblemSolvingFromFirstPrinciples.InterestingProblems;

class Program
{
    static void Main(string[] args)
    {
        CountVehicle cv = new CountVehicle();
        string[] carSequence = ["sedan S1 enters","sedan S2 enters","sedan S3 enters","truck T1 enters","sedan S2 leaves","truck T2 enters"];
        Console.WriteLine(cv.CountVehicleImpl(carSequence,2));
        
    }
}
