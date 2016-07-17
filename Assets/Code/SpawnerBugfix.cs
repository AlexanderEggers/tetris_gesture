using UnityEngine;
using System.Collections;

public class SpawnerBugfix : MonoBehaviour {

    public GameObject[] spawnables;

    void Start()
    {
        GameObjectUtil.spawnables = spawnables;
    }
}
