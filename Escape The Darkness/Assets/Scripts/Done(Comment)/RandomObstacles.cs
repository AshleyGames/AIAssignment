using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObstacles : MonoBehaviour
{
    public Transform[] spawnPoints;
    public float spawnTime = 10F;
    //public GameObject Rock;
    public GameObject[] Obstacles;
    public Transform bestPosition = null;
    public float bestScore = float.NegativeInfinity;

    public GameObject LeftLane;
    public GameObject MiddleLane;
    public GameObject RightLane;

    private int Left = 0;
    private int Middle = 0;
    private int Right = 0;


    private void Start()
    {
        InvokeRepeating("spawnController", spawnTime, spawnTime);

       
       
    }

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

        else if (Left > Right)
        {
            if (spawnPoint.transform.parent.gameObject == LeftLane)

            {

                return 10;

            }
        }

        return 0;
    } 

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
        //int spawnIndex = Random.Range(0, spawnPoints.Length);

        int objectIndex = Random.Range(0, Obstacles.Length);

        Instantiate(Obstacles[objectIndex], bestPosition.position, bestPosition.rotation, bestPosition.transform.parent);

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

        bestScore = float.NegativeInfinity;

   
     }


       
}

    
