using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GearBox
{
    public virtual int GetTopGear()
    {
        return 6;
    }
    protected abstract void TurnGears();
   
}
