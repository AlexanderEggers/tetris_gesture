using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ComplexPinchDistance : ComplexCondition {

    private float minDistance, maxDistance;

    public ComplexPinchDistance(float minDistance, float maxDistance)
    {
        this.minDistance = minDistance;
        this.maxDistance = maxDistance;
    }

    public override bool isSatisfied(Hand hand)
    {
        return minDistance <= hand.PinchDistance && maxDistance >= hand.PinchDistance;
    }



}
