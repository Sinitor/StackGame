using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static event Action onCubeSpawned = delegate { };
    private Spawner [] spawners;
    private int spawnerIndex;
    private Spawner currentSpawner;

    private void Awake()
    {
        spawners = FindObjectsOfType<Spawner>();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 
            if(MovingCube.CurrentCube != null)
               MovingCube.CurrentCube.Stop();

            spawnerIndex = spawnerIndex == 0  ? 1 : 0;
            currentSpawner = spawners[spawnerIndex];

            currentSpawner.SpawnCube();
            onCubeSpawned();
        }
    }
}
