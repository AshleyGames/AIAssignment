using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Text LivesText;

    public int HealthCount = 10;

    private bool IsDead = false;


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Hazards")
        {
            HealthCount--;
            LivesText.text = "Lives: " + HealthCount;
            //This code is saying when the player touches a coin, than add 1 to the total of coins collected

            if (HealthCount == 0)
            {
                Death();
            }
            //This is saying if the players health reaches 0 then go to the death scene
        }




    }

    private void Death()
    {
        IsDead = true;
        GetComponent<Scoring>().OnDeath();
        //SceneManager.LoadScene("Death");
    }


}
