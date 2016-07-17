using UnityEngine;
using System.Collections;
using Leap;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Finger")]
public static class FingerUtils {
    

    public static bool isExtended(Finger finger)
    {
        return finger.IsExtended;
    }

    public static float timeVisible(Finger finger)
    {
        return finger.TimeVisible;
    }

    public static Vector tipPosition(Finger finger)
    {
        return finger.TipPosition;
    }

    public static Vector tipVelocity(Finger finger)
    {

        return finger.TipVelocity;
    }

    public static float length(Finger finger)
    {
        return finger.Length;
    }

    public static Vector direction(Finger finger)
    {
    
        return finger.Direction;
    }

    public static float getWidth(Finger finger)
    {
        return finger.Width;
    }
}
