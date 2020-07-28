using System;
using System.Threading;
namespace motor
{
     public class HyundaiMotor : Motor{
        public HyundaiMotor(Door door):base(door){}
        override protected void MoveMotor(Direction direction){
            Console.WriteLine("Direction is "+ direction);
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("{0}...",i);
                Thread.Sleep(1000); 
            }
            Console.WriteLine("Arrived");
        }
        
    }
    public class LGMotor : Motor{
        public LGMotor(Door door):base(door){}
        override protected void MoveMotor(Direction direction){
            Console.WriteLine("Direction is "+ direction);
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("{0}...",i);
                Thread.Sleep(500); 
            }
            Console.WriteLine("Arrived");
        }
    }
}