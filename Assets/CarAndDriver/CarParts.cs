using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarParts 
{
    private string mMaterial;
    private float mMass;
    public virtual float getPrice()
    {
        return 5 * mMass;
       

    }

}
