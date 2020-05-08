using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Text LivesText;

    public int HealthCount = 10;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Hazards")
        {
            HealthCount--;
            LivesText.text = "Lives: " + HealthCount;
            //This code is saying when the player touches a coin, than add 1 to the total of coins collected

            if (HealthCount == 0)
            {
                SceneManager.LoadScene("Death");
            }
            //This is saying if the players health reaches 0 then go to the death scene
        }




    }


}
