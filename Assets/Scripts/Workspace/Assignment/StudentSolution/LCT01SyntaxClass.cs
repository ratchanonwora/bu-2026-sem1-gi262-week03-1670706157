using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public void Move()
        {
            Debug.Log("Car is moving");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }

        public void Honk()
        {
            Debug.Log("Car is honking");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {

            Car car = new Car();
            car.Move();
            car.Turn();
            car.Honk();
        }
    }
}
