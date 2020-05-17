using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject[] groundPrefabs;

    private Transform playerTransform;
    private float spawnX = 50.0f;
    private float groundLength = -50.0f;
    private float safeZone = 60.0f;
    private int amnGroundOnScreen = 10;

    private List<GameObject> ActiveGround;

    void Start()
    {
        ActiveGround = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < amnGroundOnScreen; i++)
        {
            SpawnGround();
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(playerTransform.position.x + safeZone  < (spawnX - amnGroundOnScreen * groundLength))
        {
            SpawnGround();
            DeleteGround();
        }
    }

    private void SpawnGround (int prefabIndex = -1)
    {
        GameObject go;
        go = Instantiate(groundPrefabs[0]) as GameObject;
        go.transform.SetParent(transform);
        go.transform.position = Vector3.right * spawnX;
        spawnX += groundLength;
        ActiveGround.Add(go);
    }
    private void DeleteGround()
    {
        Destroy(ActiveGround[0]);
        ActiveGround.RemoveAt(0);
    }
}
