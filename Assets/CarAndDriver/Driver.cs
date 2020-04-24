using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver
{
    private Car mCar;
    private void Drive()
    {
        Debug.Log("I am a driver, and I will now make a car.");
        mCar = new Car();
        mCar.AddDriver(this);

        Debug.Log("Let's drive!");

        //
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
