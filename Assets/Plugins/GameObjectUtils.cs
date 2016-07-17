using UnityEngine;
using System.Collections;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("Gameobject")]
public static class GameObjectUtils {
    


    public static void setActive(GameObject obj, bool state)
    {
        obj.SetActive(state);
    }

}
