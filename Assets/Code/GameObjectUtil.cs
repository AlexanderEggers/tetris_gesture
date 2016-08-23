using UnityEngine;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("GameObject")]
public static class GameObjectUtil
{
    public static GameObject[] spawnables;

    public static GameObject getRandomGameObject()
    {
        return spawnables[Random.Range(0, spawnables.Length)] as GameObject;
    }
}
