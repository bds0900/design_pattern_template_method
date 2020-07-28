using System;

namespace motor
{
    class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Console.WriteLine("Hyundai elevator");
            HyundaiMotor hyundaiMotor=new HyundaiMotor(door);
            hyundaiMotor.Move(Direction.UP);

            Console.WriteLine("LG elevator");
            LGMotor lgMotor= new LGMotor(door);
            lgMotor.Move(Direction.DOWN);
        }
    }
}
