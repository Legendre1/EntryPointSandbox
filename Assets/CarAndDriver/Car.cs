using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car
{
    private Driver mDriver;

    public void AddDriver(Driver d)
    {
        mDriver = d;
        Debug.Log("I am a car, and I now have driver: " + mDriver);
    }

}
