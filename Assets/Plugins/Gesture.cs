using UnityEngine;
using System.Collections;
using Leap;

public class Gesture {

    protected bool[] fingerStates { get; private set; }

    public Gesture()
    {

    }

    public Gesture(bool[] fingerStates)
    {
        this.fingerStates = fingerStates;
    }

    public virtual bool isSatisfied(Hand hand)
    {
        for(int i=0; i<5;i++)
        {
            if (hand.Fingers[i].IsExtended != fingerStates[i])
                return false; 
        }
        return true;
    }


}
