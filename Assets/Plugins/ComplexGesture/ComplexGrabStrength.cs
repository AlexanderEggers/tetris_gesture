using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ComplexGrabStrength : ComplexCondition {


    private float minStrength, maxStrength;

    public ComplexGrabStrength(float min, float max)
    {
        this.minStrength = min;
        this.maxStrength = max;
    }

    public override bool isSatisfied(Hand hand)
    {
        return minStrength <= hand.GrabStrength && maxStrength >= hand.GrabStrength;
    }
}
