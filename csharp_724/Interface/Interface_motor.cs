using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_724.HeaderFiles_Phidget;
using csharp_724.motorfile_Zaber;

namespace csharp_724.Interface
{
    internal interface Interface
    {
        bool motor_initialise();
        void motor_move();
    }
    class Phidgets : Interface
    {
        motor_Phidget mc; 
        public bool motor_initialise()
        {
            return mc.motor_initialise();
        }
        public void motor_move()
        {

        }
    }
    class Zaber : Interface
    {
        motor_Zaber mc;
        public bool motor_initialise()
        {
            return mc.motor_initialise();
        }

        public void motor_move()
        {

        }
    }
}
