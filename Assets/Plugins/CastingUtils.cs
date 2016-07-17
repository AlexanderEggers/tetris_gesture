using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using System;

[ActionLibrary, uFrameCategory("Casting")]
public static class CastingUtils{
    

    public static Int64 int32to64(Int32 value)
    {
        return (Int64)value;
    }
}
