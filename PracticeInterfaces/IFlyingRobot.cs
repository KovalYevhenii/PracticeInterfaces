using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInterfaces
{
    interface IFlyingRobot : IRobot
    {
        default new string GetRobotType()
        {
            return "I am a flying robot";
        }
    }
}
