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

                stepper.Engaged = true;
                voltage.DeviceSerialNumber=123456;
                voltage.Channel = 0;
                stepper.Open(Phidget.DefaultTimeout);
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
