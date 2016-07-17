using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ComplexGrabAngle : ComplexCondition {


    private float minAngle, maxAngle;

    public ComplexGrabAngle(float min, float max)
    {
        this.minAngle = min;
        this.maxAngle = max;
    }


    public override bool isSatisfied(Hand hand) {
        
        return minAngle <= hand.GrabAngle && maxAngle >= hand.GrabAngle;
    }
}
