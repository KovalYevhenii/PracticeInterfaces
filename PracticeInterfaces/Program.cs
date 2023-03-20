namespace PracticeInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter quadcopter = new();
            Console.WriteLine(((IFlyingRobot)quadcopter).GetRobotType());
            Console.WriteLine(quadcopter.GetInfo()); 
            quadcopter.Charge();
        }
    }
}