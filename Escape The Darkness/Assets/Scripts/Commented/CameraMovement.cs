using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    //I can drag and drop the game object, in this case the player into the public varable. this is what the camera will follow

    public float smoothSpeed = 0125f;
    public Vector3 offset;
    //This public varable alllows be the change the axis of where the camera is position, so the player can see the character and the upcoming obstacles

   
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
    //This allows the transform of the camera to move, based on the position of the player
}
