using System;
using System.Linq;

namespace MyElevator
{
    public class Elevator : IElevator<Elevator>
    {

        public int currentFloor;
        public bool emergenyStop;
        public int[] floorsToVisit;


        public int numberOfElevators()
        {
            int numberOfElevators = 2;
            return numberOfElevators;
        }

        public void changeFloors()
        {
            if (floorsToVisit.Count() > 0)
            {

            }
        }


        public void doorControls()
        {
            bool openDoors = false;
            bool closeDoors = false;
            if (openDoors)
            {
            }
        }

        public void emergencyBrakes(bool emergencyStop)
        {
            if (emergenyStop)
            {
                bool continueMoving = false;
                bool callAuthorities = true;
                if (callAuthorities)
                {
                    initiateResponse();
                }
            }
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

        public void initiateResponse()
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
    }

}
