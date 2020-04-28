using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Standard : Transmission
{
    
    public void PutInGear(int Gear)
    {
        Debug.Log("I am in gear " + Gear);
    }
    public void GrindGears()
    {
        Debug.Log("Krggggksjjnk");
        TransmissionEngaged();

    }
    
}
