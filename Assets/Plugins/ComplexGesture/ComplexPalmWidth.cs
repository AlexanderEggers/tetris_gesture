using UnityEngine;
using System.Collections;
using Leap;
using System;

public class ComplexPalmWidth : ComplexCondition {

    private float minWidth, maxWidth;

    public ComplexPalmWidth(float minWidth, float maxWidth)
    {
        this.minWidth = minWidth;
        this.maxWidth = maxWidth;
    }

    public override bool isSatisfied(Hand hand)
    {
        return minWidth <= hand.PalmWidth && maxWidth >= hand.PalmWidth;
    }
}
