using System;
using System.Collections.Generic;
using System.Text;

namespace MyElevator
{
    public interface IElevator<T>
    {
        int changeFloors(int currentFloor, int nextFloor);
        void buttonPanelControl();
        bool emergencyBrakes(bool emergencyStop);
        bool returnToHomeFloor(int numberOfPassengers);
        bool atCapacity(int numberOfPassengers, int capacity);
        int pickupPassengers(int numberOfPassengers);
        List<int> nextFloor(List<int> floorsToVisit);
    }
}
