using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //This allows me to drag and drop the UI text game object, into the public script for the gameObject
    public Text LivesText;

    public int HealthCount = 10;
    //This allows me to chnage the total health count varable, in the script


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Hazards")
            //This is saying only do this varible if the tags on the gameobject is hazards.
        {
            HealthCount--;
            LivesText.text = "Lives: " + HealthCount;
            //This code is saying when the player touches a hazarads, than minus 1 from the lives count

            if (HealthCount == 0)
            {
                Death();
            }
            //This is saying if the players health reaches 0 then go to the death variable, which takes the player to the death scene
        }
    }

    private void Death()
    {
      SceneManager.LoadScene("Death");
    }


}
