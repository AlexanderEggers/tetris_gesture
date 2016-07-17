using UnityEngine;
using System.Collections;
using Leap;
using System;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Gestures")]
public static class GestureUtils  {


    private static IDictionary dictionary = new System.Collections.Generic.Dictionary<object, Gesture>();

    public static void registerGesture(object key, bool thumb, bool index, bool middle, bool fourth, bool fifth)
    {
        dictionary.Add(key, new Gesture(new bool[] {thumb,index,middle,fourth,fifth}));
    }

    public static void isGestureSatisified(object key, Hand hand, Action yes, Action no)
    {
        if ((dictionary[key] as Gesture).isSatisfied(hand))
        {
            yes();
        }
        else
            no();
    }
}
