using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using System;

[ActionLibrary, uFrameCategory("Conditions")]
public static class ConditionsUtils {
    
    public static void isNull(object toCheck, Action yes, Action no)
    {
        if (toCheck == null)
            yes();
        else
            no();
    }
}
