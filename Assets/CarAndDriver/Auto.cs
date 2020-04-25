using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : Trans
{
private Car mCar;
    private void InGear()
    {
        Debug.Log("Now in drive mode");
        mCar = new Car();
        mCar.AddAuto(this);

        GrindGears();

        Debug.Log("Vroom");

        //Alex begin here!
        
    }



    //Entry point connection from Unity. Alex, ignore this section for now
   // #region Static Access

    //private static Auto sAuto;
    //public static void InitializeAuto()
    //{
       // sAuto = new Auto();
        //sAuto.InGear();
    //}

    //#endregion
}