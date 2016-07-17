using UnityEngine;
using System.Collections;
using Leap;

public class ComplexFingerState : ComplexCondition {

    private bool[] fingerStates;
    

    public ComplexFingerState(bool[] fingerStates)
    {
        this.fingerStates = fingerStates;
    }

    public override bool isSatisfied(Hand hand)
    {

        for(int i=0; i<fingerStates.Length; i++)
        {

            if (hand.Fingers[i].IsExtended != fingerStates[i]) return false;
        }

        return true;
    }
}
