using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarParts 
{
    private string mMaterial;
    private float mMass;
    public virtual void getPrice()
    {
        return 5 * mMass;

    }

}
