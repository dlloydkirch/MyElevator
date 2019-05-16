using System;
using System.Collections.Generic;
using System.Linq;

namespace MyElevator
{

    /// <summary>
    /// This class implements the IElevator interface to function like an elevator
    /// </summary>
    public class Elevator : IElevator<Elevator>
    {

        int currentFloor = 0;
        int nextFloorToVisit = 0;
        bool emergenyStop = false;
        List<int> floorsToVisit = new List<int>();
        bool doorClosed = false;
        int capacity = 10;

        /// <summary>
        /// This method will pickup new passengers and check for capacity by calling the atCapacity method.
        /// </summary>
        /// <param name="numberOfPassengers"></param>
        /// <returns></returns>
        public int pickupPassengers(int numberOfPassengers)
        {
            doorClosed = false;
            int incomingPassengers = 0;
            numberOfPassengers += incomingPassengers;
            if (atCapacity(numberOfPassengers, capacity))
            {
                Console.WriteLine("I'm sorry, the elevator is at capacity.");
                doorClosed = true;
                return numberOfPassengers - incomingPassengers;
            }
            doorClosed = true;
            return numberOfPassengers;
        }

        /// <summary>
        /// This method handles floor changes and calls the pickup paseenger method.
        /// </summary>
        /// <param name="currentFloor"></param>
        /// <param name="nextFloor"></param>
        /// <returns></returns>
        public int changeFloors(int currentFloor, int nextFloor)
        {
            int numberOfPassengers = 0;
            currentFloor = nextFloor;
            pickupPassengers(numberOfPassengers);
            return currentFloor;
        }

        /// <summary>
        /// This method would apply the emergency braking on the elevator - preventing it from moving to another floor.
        /// </summary>
        /// <param name="emergencyStop"></param>
        /// <returns></returns>
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

        /// <summary>
        /// This method indicates if the elevator should return to its home floor.
        /// </summary>
        /// <param name="numberOfFloorsToVisit"></param>
        /// <returns></returns>
        public bool returnToHomeFloor(int numberOfFloorsToVisit)
        {
            if (numberOfFloorsToVisit == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method could be implemented to contorl other button on the elevator button panel
        /// </summary>
        public void buttonPanelControl()
        {
            int pressedButton = 4;
            floorsToVisit.Add(pressedButton);
        }

        /// <summary>
        /// This method checks if the elevator is at capacity
        /// </summary>
        /// <param name="numberOfPassengers"></param>
        /// <param name="capacity"></param>
        /// <returns></returns>
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


        /// <summary>
        /// This method takes the list of floors to visit and returns the list with the visited floor removed.
        /// </summary>
        /// <param name="floorsToVisit"></param>
        /// <returns></returns>
        public List<int> nextFloor(List<int>floorsToVisit)
        {
            if (!emergencyBrakes(false))
            {
                floorsToVisit = floorsToVisit.OrderBy(o => o).ToList();
                if (floorsToVisit.Count > 0)
                {
                    currentFloor = floorsToVisit[0];
                    Console.WriteLine("Visiting Floor - " + floorsToVisit[0]);
                    if (floorsToVisit.Count > 1)
                    {
                        nextFloorToVisit = floorsToVisit[1];
                    }
                    else
                    {
                        nextFloorToVisit = 0;
                    }
                    currentFloor = changeFloors(currentFloor, nextFloorToVisit);
                    floorsToVisit.Remove(floorsToVisit[0]);
                }
            }
            else
            {
                return new List<int>();
            }
            return floorsToVisit; // floorsToVisit;
        }

        public static void Main()
        {
            Elevator elevator = new Elevator();
            List<int> floorsToVisit = new List<int>();

            //Here I add floors to visit - can be as many or as few as wanted.
            floorsToVisit.Add(2);
            floorsToVisit.Add(6);
            floorsToVisit.Add(3);
            floorsToVisit.Add(9);
            //end adding floors to visit.

            while (floorsToVisit.Count() > 0)
            {
                floorsToVisit = elevator.nextFloor(floorsToVisit);
                elevator.returnToHomeFloor(floorsToVisit.Count);
            }
            Console.WriteLine("Returing to home floor");

        }

    }
}
