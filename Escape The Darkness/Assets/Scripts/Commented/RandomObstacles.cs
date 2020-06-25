using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    //This keeps track and makes an array for all the gameobjects/prefabs
    public Transform[] spawnPoints;
    public GameObject[] Obstacles;

    //This is how long before the first obstacle is generated
    public float spawnTime = 10F;


    public Transform bestPosition = null;
    public float bestScore = float.NegativeInfinity;

    //This keeps track of the spawnpoints in each lane
    public GameObject LeftLane;
    public GameObject MiddleLane;
    public GameObject RightLane;

    //This keeps track on how many obstacles are in each lane.
    private int Left = 0;
    private int Middle = 0;
    private int Right = 0;

    //Wait a certain amount of time (above), then generate the first obstacles
    private void Start()
    {
        InvokeRepeating("spawnController", spawnTime, spawnTime);

       
       
    }
    //These are the utility caluclations below, which says the conditions that have to be met. Before it can generate in that lane.
    float calculateUtility(Transform spawnPoint)
    {
          if (Left > Middle)
        {

            if (spawnPoint.transform.parent.gameObject == MiddleLane)

            {

                return 10;

            }



        }

      

        else if (Middle > Right)
        {
            if (spawnPoint.transform.parent.gameObject == RightLane)

            {

                return 10;

            }
        }

        else if (Left > Right)
        {
            if (spawnPoint.transform.parent.gameObject == LeftLane)

            {

                return 10;

            }
        }

      
        return 0;
    } 
    //This goes through the utility calculation, and sees what one is being met. Based on the current enviroment, chooses the correct one
    //Then instantiate it
    void spawnController()
    {

        foreach (Transform spawnIndex in spawnPoints)
        {
            float score = calculateUtility(spawnIndex);
            if (score > bestScore)
            {

                bestPosition = spawnIndex;
                bestScore = score;
            }

        }

        //This below, sayings go through the list/arrays of the obstacles. Pick one at random
        int objectIndex = Random.Range(0, Obstacles.Length);

        //This says, take the random obstacle chosen. Then take the chosen position from the utility caluclations. Generate the chosen obstacle in the chosen lane
        Instantiate(Obstacles[objectIndex], bestPosition.position, bestPosition.rotation, bestPosition.transform.parent);

        //Below, adds 1 everytime that the obstacles are genretaed in the chosen lane
        if (bestPosition.transform.parent.gameObject == LeftLane)
        {
            Left++;
        }

        if (bestPosition.transform.parent.gameObject == MiddleLane)
        {
            Middle++;
        }

        if (bestPosition.transform.parent.gameObject == RightLane)
        {
            Right++;

        }

        //This resets it every time, before a new one is generated

        bestScore = float.NegativeInfinity;

   
     }


       
}

    
