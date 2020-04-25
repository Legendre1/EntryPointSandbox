using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel 
{
    private object[] rims;

    private object[] tread;
    private Car mCar;
    public void Move()
    {
        Debug.Log("I have four wheels");
        mCar = new Car();
        mCar.AddWheel(this);

        Debug.Log("Do It!");
    }
    //#region Static Access

    //private static Wheel sWheel;
    //public static void InitializeWheel()
    //{
//        sWheel = new Wheel();
        //sWheel.Move();
    //}

    //#endregion
} 
        
    

