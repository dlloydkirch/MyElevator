using System;
using System.Collections.Generic;
using System.Text;

namespace MyElevator
{
    public interface IElevator<T>
    {
        void changeFloors();
        void doorControls();
        void buttonPanelControl();
        void emergencyBrakes(bool emergencyStop);
        bool returnToHomeFloor(int numberOfPassengers);
        int numberOfElevators();
        bool atCapacity(int numberOfPassengers, int capacity);
    }
}
