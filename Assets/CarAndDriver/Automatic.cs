using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic : Transmission
{

    public void PutInDrive()
    {
        Debug.Log("Now in drive mode");
        TransmissionEngaged();
    }
     public override int GetTopGear()
    {
        return 8;
    }
 
}