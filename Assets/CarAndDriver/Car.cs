using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car 
{
    private const int numberOfWheels = 4;
    private const int numberOfHeadLights = 2;

   
    public static int GetWheelCount()
    {
        return numberOfWheels;
    }
    public static int GetHeadLightCount()
    {
        return numberOfHeadLights;
    }
    private Driver mDriver;
    private Wheel[] mWheel;
    private Engine mEngine;
    private Automatic mAutomatic;
    private Lights mLights;
    private Standard mStandard;
    private Dictionary <string, CarParts> mCarPartsDictionary;
    

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
    public void AddAutomatic()
    {
        mAutomatic = new Automatic();
        Debug.Log("Turbodrive transmission detected");
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
        Debug.Log("Wheels Detected!");
        
    }
   
    public void StartEngine()
    {
        mEngine.Ignition();
        mCarPartsDicitonary = new Dictionary <string, CarParts>();
        mCarPartsDictionary.Add("engine", mEngine);
        mCarPartsDictionary["engine"];
    }
    public void PutInD()
    {
        mAutomatic.PutInDrive();
    }
    public void PutInFirst()
    {
        mStandard.PutInGear(1);
        mStandard.GrindGears();
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
        mAutomatic.PutInDrive();
        mWheel[0].Move();
        mLights.FlipLights();
        mEngine.Ignition();
        mEngine.RevUp();
        
    }
    
}
