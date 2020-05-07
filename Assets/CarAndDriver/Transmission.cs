using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transmission : GearBox
{
    private object[] Gears;
    


    public void TransmissionEngaged()
    {
        Debug.Log("Power Train now transferring energy to " + GetTopGear() + "-Speed Transmission");
        
    }
   protected override void TurnGears()
   {
       Debug.Log("Gears Turned");
       
   }
   
}

