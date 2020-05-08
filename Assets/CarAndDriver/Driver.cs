using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : Human
{
    private Car mCar;
    private CarBrand mCarBrand;
    private void Drive()
    {
        Debug.Log("I am a driver, and I will now make a car.");
        mCar = new Car();
        mCarBrand = CarBrand.Pontiac; 
        mCar.AddDriver(this);
        mCar.AddEngine();
        mCar.AddAutomatic();
        //mCar.PutInD();
        mCar.AddLights();
        mCar.AddWheels();
        //mCar.AddStandard();
        //mCar.PutInFirst();
        Michael();
        mCar.ActivateKitt();
        //mCar.Forward();
        //mCar.Darkness();
        //mCar.HitTheGas();
        //mCar.TurnRight();
        //mCar.TurnLeft();
       
        Debug.Log("You are driving a " + mCarBrand); 
        
        //because I inherit from Human, I can call this method
        LiveAndDie();

        Debug.Log("Let's drive!");

        //Alex begin here!
        
    }

    enum CarBrand
    {
        Toyota,
        Pontiac,
        Subaru

    }

    //Entry point connection from Unity. Alex, ignore this section for now
    #region Static Access

    private static Driver sDriver;
    public static void InitializeDriver()
    {
        sDriver = new Driver();
        sDriver.Drive();
    }

    #endregion
}
