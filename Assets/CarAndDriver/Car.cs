using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private Driver mDriver;
    private Wheel[] mWheel;
    private Engine mEngine;
    private Automattic mAutomattic;
    private Lights mLights;
    private Standard mStandard;

    public void AddDriver(Driver d)
    {
        mDriver = d;
        Debug.Log("I am a car, and I now have driver: " + mDriver);  

    }
    public void AddEngine()
    {
        mEngine = new Engine();
        Debug.Log("Knight Industries turbojet with modified afterburners detected");
    }
    public void AddAutomattic()
    {
        mAutomattic = new Automattic();
        Debug.Log("8-speed turbodrive transmission detected");
    }
    public void AddStandard()
    {
        mStandard = new Standard();
        Debug.Log("Standard transmission detected");

    }
    public void AddLights()
    {
        mLights = new Lights();
        Debug.Log("High luminosity light cluster detected");
    }

    public void AddWheels()
    {
        mWheel = new Wheel[4];
            for(int n = 0; n < 4; n++)
                {
                    mWheel[n] = new Wheel();
                }
        Debug.Log("Four Wheels Detected!");
        
    }
   
    public void StartEngine()
    {
        mEngine.Ignition();
    }
    public void PutInD()
    {
        mAutomattic.PutInDrive();
    }
    public void PutInFirst()
    {
        mStandard.PutInGear(1);
    }
    public void Forward()
    {
        mWheel[0].Move();
    }
    public void Darkness()
    {
        mLights.FlipLights();
    }
    public void HitTheGas()
    {
        mEngine.RevUp();
    }
    public void TurnRight()
    {
        for(int n = 0; n < 4; n++)
        {
            mWheel[n].WheelRotationRight(n);
        }
    }
    public void TurnLeft()
    {
        for(int n = 0; n < 4; n++)
        {
            mWheel[n].WheelRotationLeft(n);  
        }
        
    }
   
    public void ActivateKitt()
    {
        Debug.Log("K.I.T.T.: Were I to hazard a guess, I'd say into an old canyon.");
        Debug.Log("Engaging Alpha Circuit");
        mAutomattic.PutInDrive();
        mWheel[0].Move();
        mLights.FlipLights();
        mEngine.Ignition();
        mEngine.RevUp();
    }
    
}
