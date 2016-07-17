using UnityEngine;
using System.Collections;
using Leap;

//Base class for conditions used in ComplexGestures
public abstract class ComplexCondition  {

    public abstract bool isSatisfied(Hand hand);
}
