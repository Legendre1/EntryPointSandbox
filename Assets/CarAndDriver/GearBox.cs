using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GearBox
{
    public void TransmissionEngaged()
    {
        Debug.Log("Power Train now transferring energy to " + GetTopGear() + "-Speed Transmission");
        
    }
    public virtual int GetTopGear()
    {
        return 5;
    }
    protected abstract void TurnGears();
   
}
