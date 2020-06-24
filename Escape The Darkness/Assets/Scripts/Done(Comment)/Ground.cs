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
    private int amnGroundOnScreen = 5;
    private int lastPrefabIndex = 0;

    private List<GameObject> ActiveGround;

    void Start()
    {
        ActiveGround = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        for(int i = 0; i < amnGroundOnScreen; i++)
        {
            if (i < 2)
                SpawnGround (0);
            else
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
        if (prefabIndex == -1)
            go = Instantiate(groundPrefabs[RandomPrefabIndex()]) as GameObject;
        else
            go = Instantiate(groundPrefabs[prefabIndex]) as GameObject;
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

    private int RandomPrefabIndex()
    {
        if (groundPrefabs.Length <= 1)
            return 0;

        int randomIndex = lastPrefabIndex;
        while (randomIndex == lastPrefabIndex)
        {
            randomIndex = Random.Range(0, groundPrefabs.Length);
        }

        lastPrefabIndex = randomIndex;
        return randomIndex;

    }
}
