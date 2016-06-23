using UnityEngine;
using uFrame.Attributes;

[ActionLibrary, uFrameCategory("spawner")]
public static class Spawner
{
    // Groups
    public static GameObject[] groups;

    public static void spawnNext(Vector3 position)
    {
        // Random Index
        int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        GameObject.Instantiate(groups[i],
                    position,
                    Quaternion.identity);
    }
}