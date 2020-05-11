using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[] groundPrefabs;

    private Transform playerTransform;
    private float spawnZ = 115.0f;
    private float groundLength = 5.0f;
    private int amnGroundOnScreen = 10;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        SpawnGround();
        SpawnGround();
        SpawnGround();
        SpawnGround();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnGround (int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(groundPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.forward * spawnZ;
        spawnZ += groundLength;
    }
}
