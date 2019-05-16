using System;
using System.Collections.Generic;
using System.Linq;

namespace MyElevator
{

    //This class implements the IElevator interface.
    //It contains all methods and their implementation for the Elevator program.
    //
    public class Elevator : IElevator<Elevator>
    {

        public int currentFloor;
        public bool emergenyStop;
        public List<int> floorsToVisit;

        public int pickupPassengers(int numberOfPassengers)
        {
            int incomingPassengers = 0;
            int capacity = 5;
            if (atCapacity(numberOfPassengers, capacity))
            {
                numberOfPassengers += incomingPassengers;
            }
            return numberOfPassengers;
        }

        public List<int> changeFloors(int currentFloor, int nextFloor)
        {
            int numberOfPassengers = 0;
            currentFloor = nextFloor;
            pickupPassengers(numberOfPassengers);
            floorsToVisit.Remove(currentFloor);
            return floorsToVisit;
        }


        public void doorControls()
        {
            bool openDoors = false;
            if (openDoors)
            {
            }
        }

        public bool emergencyBrakes(bool emergencyStop)
        {
            if (emergenyStop)
            {
                bool callAuthorities = true;
                if (callAuthorities)
                {
                    return true;
                }
                return true;
            }
            return false;
        }

        public bool returnToHomeFloor(int numberOfPassengers)
        {
            if (numberOfPassengers == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void buttonPanelControl()
        {

        }

        public bool atCapacity(int numberOfPassengers, int capacity)
        {
            if (numberOfPassengers >= capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void nextFloor(List<int>floorsToVisit)
        {
            if (!emergencyBrakes(false))
            {
                floorsToVisit = floorsToVisit.OrderBy(o => o).ToList();
                changeFloors(floorsToVisit[0], floorsToVisit[1]);
            }
        }

        public void Main(string[] args)
        {
            List<int> floorsToVisit = new List<int>();
            while (floorsToVisit.Count() >= 0)
            {
                nextFloor(floorsToVisit);
            }
        }
    }
}
