using UnityEngine;
using System.Collections;
using uFrame.Attributes;
using Leap;

[ActionLibrary, uFrameCategory("Vector")]
public static class VectorUtils  {
    

    public static Vector3 toVector3(Vector vector)
    {
        return new Vector3(vector.x, vector.y, vector.z);
    }

    public static Vector toVector(Vector3 vector3)
    {
        return new Vector(vector3.x, vector3.y, vector3.z);
    }
}
