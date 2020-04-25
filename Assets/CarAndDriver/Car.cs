using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private Driver mDriver;
    private Wheel[] mWheel;
    private Engine mEngine;
    private Trans mTrans;
    private Lights mLights;

    public void AddDriver(Driver d)
    {
        mDriver = d;
        Debug.Log("I am a car, and I now have driver: " + mDriver);
        
    }
      public void AddAuto(Trans a)
    {
        mTrans = a;
        Debug.Log("Now I have a transmission: " + mTrans);
    }
    public void AddWheel(Wheel w)
    {
        mWheel = new Wheel[4];
            for(int n = 0; n < 4; n++)
                {
                    mWheel[n] = new Wheel();
                }
        Debug.Log("I Got some wheels!");
    }
 
}
