using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic : Transmission
{

    public void PutInDrive()
    {
        Debug.Log("Now in drive mode");
        TransmissionEngaged();
        TurnGears();
    }
     public override int GetTopGear()
    {
        return 8;
    }
    
}