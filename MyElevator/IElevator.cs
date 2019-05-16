using System;
using System.Collections.Generic;
using System.Text;

namespace MyElevator
{
    public interface IElevator<T>
    {
        List<int> changeFloors(int currentFloor, int nextFloor);
        void doorControls();
        void buttonPanelControl();
        bool emergencyBrakes(bool emergencyStop);
        bool returnToHomeFloor(int numberOfPassengers);
        bool atCapacity(int numberOfPassengers, int capacity);
        int pickupPassengers(int numberOfPassengers);
    }
}
