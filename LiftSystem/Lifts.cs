using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Elevator
{
    class Lifts
    {
        public decimal Weight { set; get; }
        public int CurrentPosition { set; get; }
        //  private int capacity = 0;
        public const int TotalCapacity = 500;
        public string lockDownStatus { set; get; }
        enum Direction
        {
            UP,
            DOWN,
            STATIONARY
        }
        public Lifts()
        {
            // this.capacity = TotalCapacity;
        }
        public string DirectionSet { set; get; }
        public ArrayList LoadLiftData(string obj)
        {

            ArrayList tempArrayList = new ArrayList();
            if (obj == "not locked")
            {

                Lifts objectone = new Lifts();
                objectone.CurrentPosition = 2;
                objectone.Weight = 200;
                objectone.DirectionSet = "DOWN";
                tempArrayList.Add(objectone);
                Lifts objecttwo = new Lifts();
                objecttwo.CurrentPosition = 3;
                objecttwo.Weight = 250;
                objecttwo.DirectionSet = "UP";
                tempArrayList.Add(objecttwo);
                Lifts objectthree = new Lifts();
                objectthree.CurrentPosition = 4;
                objectthree.Weight = 300;
                objectthree.DirectionSet = "DOWN";
                tempArrayList.Add(objectthree);
                Lifts objectfour = new Lifts();
                objectfour.CurrentPosition = 1;
                objectfour.Weight = 400;
                objectfour.DirectionSet = "UP";
                tempArrayList.Add(objectfour);

            }
            else if (obj == "locked")
            {
                Lifts objectone = new Lifts();
                objectone.CurrentPosition = 0;
                objectone.Weight = 0;
                objectone.DirectionSet = "null";
                tempArrayList.Add(objectone);

            }

            return tempArrayList;


        }
    }
}

