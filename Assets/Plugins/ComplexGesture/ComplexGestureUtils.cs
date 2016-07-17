using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using System;

[ActionLibrary, uFrameCategory("Complex Gesture")]
public static  class ComplexGestureUtils {


    private static IDictionary dictionary = new System.Collections.Generic.Dictionary<object, ComplexGesture>();

    private static IDictionary updateDictionary = new System.Collections.Generic.Dictionary<ComplexGesture, System.Action>();

    public static ComplexGesture createComplexGesture()
    {

        return new ComplexGesture();
    }

    public static ComplexGesture addComplexFingerState(ComplexGesture gesture, bool first, bool second, bool third, bool fourth, bool fifth)
    {
        ComplexFingerState fingerState = new ComplexFingerState(new bool[] { first, second, third, fourth, fifth });
        gesture.addCondition(fingerState);
        return gesture;
    }

    public static ComplexGesture addComplexPalmWidth(ComplexGesture gesture, float min, float max)
    {
        ComplexPalmWidth palmWidth = new ComplexPalmWidth(min, max);
        gesture.addCondition(palmWidth);
        return gesture;
    }

    public static ComplexGesture addComplexPinchDistance(ComplexGesture gesture, float min, float max)
    {
        ComplexPinchDistance distance = new ComplexPinchDistance(min, max);
        gesture.addCondition(distance);
        return gesture;
    }

    public static ComplexGesture addComplexPinchStrength(ComplexGesture gesture, float min, float max)
    {
        ComplexPinchStrength strength = new ComplexPinchStrength(min, max);
        gesture.addCondition(strength);
        return gesture;
    }

    public static ComplexGesture addComplexGrabStrength(ComplexGesture gesture, float min, float max)
    {
        ComplexGrabStrength strength = new ComplexGrabStrength(min, max);
        gesture.addCondition(strength);
        return gesture;
    }

    public static ComplexGesture addComplexGrabAngle(ComplexGesture gesture, float min, float max)
    {
        ComplexGrabAngle angle = new ComplexGrabAngle(min, max);
        gesture.addCondition(angle);
        return gesture;
    }

    
    public static void isComplexGestureSatisfied(object key, Leap.Hand hand, Action yes, Action no)
    {
        ComplexGesture gesture = dictionary[key] as ComplexGesture;
        if(gesture.isSatisfied(hand))
        {
            yes();
        } else
        {
            no();
        }
    }

    public static void registerComplexGesture(ComplexGesture gesture, object key)
    {
        dictionary.Add(key, gesture);
    }
    /*
    public static void addComplexToUpdate(ComplexGesture gesture, System.Action onDetect)
    {
    }

    public class ComplexUpdater : MonoBehaviour
    {
        void Update()
        {
            ICollection keys = updateDictionary.Keys;
            IEnumerator enumerator = keys.GetEnumerator();
            do
            {
                ComplexGesture gesture = enumerator.Current as ComplexGesture;
                

            } while (enumerator.MoveNext());
        }
        
    }
    */







}
