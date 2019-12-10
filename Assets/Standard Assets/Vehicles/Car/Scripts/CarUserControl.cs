using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        float timeLeft = 3.0f;
        private CarController m_Car; // the car controller we want to use

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {

            // pass the input to the car!
            float h = Input.GetAxis("Horizontal");
            float v = 1; //Input.GetAxis("Vertical");
            float handbrake = Input.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);

            //m_Car.Move(h, v, v, 0f);

            if (m_Car.CurrentSpeed == 0)
            {
                //timeLeft is going to be equal to however much time there is left - however much time has gone by.
                timeLeft = timeLeft - Time.time;
                if (timeLeft < 0)
                {


                    //gameObject.transform.position.x = mark.transform.position.x
                }
            }
        }

    }
}