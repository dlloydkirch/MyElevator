using System;

namespace MyElevator
{
    public class Elevator : IElevator<Elevator>
    {

        public void changeFloors()
        {
        }

        public void doorControls()
        {
        }

        public void emergencyBrakes()
        {
            bool emergencyBrake = true;
            if (emergencyBrake)
            {
                bool continueMoving = false;
                bool callAuthorities = true;
                if (callAuthorities)
                {
                    initiateResponse();
                }
            }
        }

        public void buttonPanelControl()
        {

        }
        public void initiateResponse() { }

    }
}
