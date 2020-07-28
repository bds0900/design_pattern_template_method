using System;
namespace motor
{
    public enum DoorStatus {CLOSED,OPEND}
    public enum MotorStatus{MOVING,STOPPED}
    public enum Direction{UP,DOWN}
    public class Door{
        private DoorStatus doorStatus;

        public Door(){doorStatus=DoorStatus.CLOSED;}
        public DoorStatus GetDoorStatus(){return doorStatus;}
       
        public void Close(){doorStatus=DoorStatus.CLOSED;}
        public void Open(){doorStatus=DoorStatus.OPEND;}
    }
    
}