using System;
namespace motor
{
    public abstract class Motor{
        protected Door door;
        private MotorStatus motorStatus;
        
        public Motor(Door door){
            this.door=door;
            motorStatus=MotorStatus.STOPPED;
        }
        public MotorStatus GetMotorStatus(){return motorStatus;}
        public void SetMotorStatus(MotorStatus motorStatus){this.motorStatus=motorStatus;}
        abstract protected void MoveMotor(Direction direction);
        public void Move(Direction direction){
            motorStatus=GetMotorStatus();
            if(motorStatus==MotorStatus.MOVING) return;

            DoorStatus doorStatus=door.GetDoorStatus();
            if(doorStatus==DoorStatus.OPEND) door.Close();
            Console.WriteLine("Closing the door");

            SetMotorStatus(MotorStatus.MOVING);

            //concret class implements this method
            MoveMotor(direction);

            SetMotorStatus(MotorStatus.STOPPED);
            door.Open();
            Console.WriteLine("Opening the door");
        }
    }
}