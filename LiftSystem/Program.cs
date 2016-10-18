using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lift1;
            Lifts obj1 = new Lifts();
            for (int h = 1; h <= 2; h++)
            {
                if (h == 1)
                {

                    obj1.lockDownStatus = "not locked";
                    int levels;
                    lift1 = obj1.LoadLiftData(obj1.lockDownStatus);
                    Console.WriteLine("Enter Your Direction:Press UP for going in upwards direction/Press DOWN for going in downwards direction/");
                    string dir = Console.ReadLine();
                    Console.WriteLine("Enter Your Floor Number");
                    string number = Console.ReadLine();
                    if (Int32.TryParse(number, out levels))
                    {

                    }
                    decimal[] weight = new decimal[4];
                    string[] direct = new string[4];
                    int[] floors = new int[4];
                    int i = 0;
                    foreach (object o1 in lift1)
                    {
                        Lifts ob = (Lifts)o1;
                        Console.WriteLine("Lift number " + i + " is going in " + ob.DirectionSet + " Direction" + " and is currently on " + ob.CurrentPosition + " floor" + " and its current weight is " + ob.Weight + " kg");

                        floors[i] = ob.CurrentPosition;
                        direct[i] = ob.DirectionSet;
                        weight[i] = ob.Weight;
                        i = i + 1;

                    }

                    int floorcounter = 0;
                    decimal smallestweight = 2000;
                    int counterposition = 100;
                    int levelDiff = 0;
                    for (int k = 0; k <= 3; k++)
                    {
                        if (levels > 4)
                        {
                            if (direct[k].ToUpper() == "UP")
                            {
                                if (floors[k] < levels)
                                {

                                    levelDiff = levels - floors[k];
                                }
                                else
                                {
                                    levelDiff = floors[k] - levels;
                                }

                                if (levelDiff < counterposition)
                                {
                                    counterposition = levelDiff;

                                    if (weight[k] < smallestweight)
                                    {
                                        smallestweight = weight[k];
                                        floorcounter = k;
                                    }

                                }



                            }

                        }
                        else if (levels <= 4)
                        {

                            if (dir.ToUpper() == "DOWN")
                            {
                                if ((floors[k] >= levels && direct[k].ToUpper() == "DOWN"))
                                {


                                    if (weight[k] < smallestweight)
                                    {
                                        smallestweight = weight[k];
                                        floorcounter = k;
                                    }





                                }
                            }
                            else if (dir.ToUpper() == "UP")
                            {
                                if ((floors[k] <= levels && direct[k].ToUpper() == "UP"))
                                {


                                    if (weight[k] < smallestweight)
                                    {
                                        smallestweight = weight[k];
                                        floorcounter = k;
                                    }





                                }
                            }

                        }

                    }

                    Console.WriteLine("Lift " + floorcounter + " is available....");
                }
                if (h == 2)
                {
                    Console.WriteLine("Fire Alarm has stared:");
                    obj1.lockDownStatus = "locked";

                    lift1 = obj1.LoadLiftData(obj1.lockDownStatus);
                    Console.WriteLine("Enter Your Direction:Press UP for going in upwards direction/Press DOWN for going in downwards direction/");
                    string di = Console.ReadLine();
                    Console.WriteLine("Enter Your Floor Number");
                    string flrnum = Console.ReadLine();
                    foreach (object o in lift1)
                    {
                        Lifts lft = (Lifts)o;
                        if (lft.DirectionSet == "null")
                        {
                            Console.WriteLine("Lifts are not Available and are in Locked down status!");

                        }

                    }
                }
            }



        }


    }









}