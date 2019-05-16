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
        void emergencyBrakes();

    }
}
