using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ComplexPinchStrength : ComplexCondition {


    private float minStrength, maxStrength;

    public ComplexPinchStrength(float minStrength, float maxStrength)
    {
        this.minStrength = minStrength;
        this.maxStrength = maxStrength;
    }

    public override bool isSatisfied(Hand hand)
    {
        return minStrength <= hand.PinchStrength && maxStrength >= hand.PinchStrength;
    }
}
