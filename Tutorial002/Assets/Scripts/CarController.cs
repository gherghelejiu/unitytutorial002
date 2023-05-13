using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float carSpeed = 10f;
    [SerializeField] private float carSpeedGain = 1f;
    [SerializeField] private float turnSpeed = 200f;

    private int steerValue = 0;

    public void Steer(int newValue)
    {
        steerValue = newValue;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, turnSpeed * steerValue * Time.deltaTime, 0f);

        carSpeed += carSpeedGain * Time.deltaTime;
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);
    }
}
