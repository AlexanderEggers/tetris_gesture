using UnityEngine;
using System.Collections;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Rigidbody")]
public static class RigidbodyUtils{
    

    public static void setForwardVelocity(Rigidbody rigidbody, float speed )
    {
        rigidbody.velocity = rigidbody.transform.forward * speed;
    }
}
