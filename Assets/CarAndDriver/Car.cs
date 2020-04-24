using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    private Driver mDriver;
    private Wheel[] mWheels;

    public void AddDriver(Driver d)
    {
        mDriver = d;
        Debug.Log("I am a car, and I now have driver: " + mDriver);

        mWheels = new Wheel[4];
        for(int n = 0; n < 4; n++)
        {
            mWheels[n] = new Wheel();
        }
    }

}
