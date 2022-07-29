using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidget22;
using Phidget22.Events;
using csharp_724.HeaderFiles_Phidget;

namespace csharp_724.HeaderFiles_Phidget
{
    public class motor_Phidget
    {
        Stepper stepper = new Stepper();
        VoltageInput voltage = new VoltageInput();
        
        public bool motor_initialise()
        {
            try
            {

                bool Engaged = stepper.Engaged;//get engaged

                voltage.DeviceSerialNumber=123456;

                voltage.Channel = 0;

                voltage.Attach+=voltage_Attach;
                voltage.Detach+=voltage_Detach;
                voltage.Error += voltage_Error;
                stepper.PositionChange += stepper_PositionChange;

                stepper.Open(Phidget.DefaultTimeout);

                double MaxPosition = stepper.MaxPosition; 
                double MinPosition = stepper.MinPosition;
                double VelocityLimit = stepper.VelocityLimit;
                double CurrentLimit = stepper.CurrentLimit;
                double Acceleration = stepper.Acceleration;

                stepper.Engaged = true;//set engaged
                stepper.Close();
            }   catch(PhidgetException ex)
            {
                Console.WriteLine("Failure: " + ex.Message); 
                return false;
            }

            //ch.Open(Phidget.DefaultTimeout);
            //ch.Engaged = true;
            //ch.Close();
            return true;
        }
        private static void voltage_Attach(object sender, Phidget22.Events.AttachEventArgs e)
        {

            // Access event source via the sender object
            VoltageInput ch = (VoltageInput)sender;

            // Access event data via the EventArgs
        }
        private static void voltage_Detach(object sender, Phidget22.Events.DetachEventArgs e)
        {

            // Access event source via the sender object
            VoltageInput ch = (VoltageInput)sender;

            // Access event data via the EventArgs
        }
        private static void voltage_Error(object sender, Phidget22.Events.ErrorEventArgs e)
        {

            // Access event source via the sender object
            VoltageInput ch = (VoltageInput)sender;

            // Access event data via the EventArgs
            ErrorEventCode code = e.Code;
            string description = e.Description;
        }
        private static void stepper_PositionChange(object sender, Phidget22.Events.StepperPositionChangeEventArgs e)
        {

            // Access event source via the sender object
            Stepper ch = (Stepper)sender;

            // Access event data via the EventArgs
            double position = e.Position;
        }
        public int motor_accreactionset(int accreaction){
            
            try
            {
                stepper.Open(Phidget.DefaultTimeout);

                stepper.Acceleration = accreaction;

                stepper.Close();
            }
            catch (PhidgetException ex)
            {
                Console.WriteLine("Failure: " + ex.Message);
            }
            return 0;
        }
        public int motor_velocitylimit(int velocitylimit)
        {
            try {
                stepper.Open(Phidget.DefaultTimeout);

                stepper.VelocityLimit = velocitylimit;

                stepper.Close();
            } catch (PhidgetException ex)
            {
                Console.WriteLine("Failure: " + ex.Message);
            }
            return 0;
        }
    }
}
