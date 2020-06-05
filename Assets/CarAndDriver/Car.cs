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
    private int mTransmissionType;
    private Driver mDriver;
    private Wheel[] mWheel;
    private Engine mEngine;
    private TransmissionAutomatic mTransmissionAutomatic;
    private HeadLights mHeadLights;
    private TransmissionStandard mTransmissionStandard;
    private Dictionary <string, CarParts> mCarPartsDictionary;

   
    
    
    public void AddDriver(Driver d)
    {
        mDriver = d;
        Debug.Log("I am a car, and I now have driver: " + mDriver);  
        
    }
    public void MakeCar(int mTransmissionType)
    {
        //Add Engine
        mEngine = new Engine();
        Debug.Log("Knight Industries turbojet with modified afterburners detected");
        
        //Add headlights
        mHeadLights = new HeadLights();
        Debug.Log("High luminosity light cluster detected");

        //Add Wheels
        mWheel = new Wheel[4];
            for(int n = 0; n < 4; n++)
                {
                    mWheel[n] = new Wheel();
                }
        Debug.Log("Wheels Detected!");

        //Add Transmission
        if(mTransmissionType == 0)
        {
            AddTransmissionStandard();
        }
        else if(mTransmissionType != 0)
        {
            AddTransmissionAutomatic();
        }

    }

    public void TurnCarOn()
    {
        //Start engine
        mEngine.Ignition();
        mCarPartsDictionary = new Dictionary <string, CarParts>();
        mCarPartsDictionary.Add("engine", mEngine);

        //HeadLights on for safety
        mHeadLights.FlipLights();

    }

    public void CheckSteering()
    {
        //Turn right
        for(int n = 0; n < 4; n++)
        {
            mWheel[n].WheelRotationRight(n);
        }

        //Turn left
        for(int n = 0; n < 4; n++)
        {
            mWheel[n].WheelRotationLeft(n);  
        }
    }

    public void DriveCar(int mTransmissionType)
    {
        //Engage Transmission; put the car in gear
        if(mTransmissionType == 0)
        {
            mTransmissionStandard.PutInGear(1);
        }
        else if(mTransmissionType != 0)
        {
            mTransmissionAutomatic.PutInDrive();
        }

        //Wheel motion
        mWheel[0].Move();

        //Press the gas; put the petal to the metal
        CarParts part = null;
        if(mCarPartsDictionary.TryGetValue("engine", out part))
        {
            CarParts tempCarParts = mCarPartsDictionary["engine"];
            Engine tempEngine = (Engine)tempCarParts;
            tempEngine.RevUp();
        }
    }

    public void AddTransmissionAutomatic()
    {
        mTransmissionAutomatic = new TransmissionAutomatic();
        Debug.Log("Turbodrive transmission detected");
    }
    public void AddTransmissionStandard()
    {
        mTransmissionStandard = new TransmissionStandard();
        Debug.Log("Standard transmission detected");

    }
    public void ActivateKitt()
    {
        //Debug.Log("K.I.T.T.: Were I to hazard a guess, I'd say into an old canyon.");
        MakeCar(1);
        Debug.Log("Engaging Alpha Circuit");
        AddTransmissionAutomatic();
        CheckSteering();
        DriveCar(1);
  
    }

    //public void ForewardMotion()
    //{
    //    mWheel[0].Move();
    //}
    
    //public void HitTheGas()
    //{
    //    CarParts part = null;
    //    if(mCarPartsDictionary.TryGetValue("engine", out part))
    //    {
    //        CarParts tempCarParts = mCarPartsDictionary["engine"];
    //        Engine tempEngine = (Engine)tempCarParts;
    //        tempEngine.RevUp();
    //    }
    //}

    //public void AddEngine()
    //{
    //    mEngine = new Engine();
    //    Debug.Log("Knight Industries turbojet with modified afterburners detected");
    //}
   
    //public void AddHeadLights()
    //{
    //    mHeadLights = new HeadLights();
    //    Debug.Log("High luminosity light cluster detected");
    //}

    //public void AddWheels()
    //{
    //    mWheel = new Wheel[4];
    //        for(int n = 0; n < 4; n++)
    //            {
    //                mWheel[n] = new Wheel();
    //            }
    //    Debug.Log("Wheels Detected!");
        
    //}
   
    //public void StartEngine()
    //{
    //    mEngine.Ignition();
    //    mCarPartsDictionary = new Dictionary <string, CarParts>();
    //    mCarPartsDictionary.Add("engine", mEngine);  
    //}

    //public void PutInD()
    //{
    //    mTransmissionAutomatic.PutInDrive();
    //}

    //public void PutInFirst()
    //{
    //    mTransmissionStandard.PutInGear(1);
    //}

  

    //public void Darkness()
    //{
    //    mHeadLights.FlipLights();
    //}

  

    //public void TurnRight()
    //{
    //    for(int n = 0; n < 4; n++)
    //    {
    //        mWheel[n].WheelRotationRight(n);
    //    }
    //}

    //public void TurnLeft()
    //{
    //    for(int n = 0; n < 4; n++)
    //    {
    //        mWheel[n].WheelRotationLeft(n);  
    //    }  
    //}
   

     
    
    
}
