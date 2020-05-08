using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameController : MonoBehaviour
{
    public InputField nameInput;
    public Button acceptButton;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if(nameInput.text.Length !=3)
        {
            acceptButton.enabled = false;
        }
        else
        {
            acceptButton.enabled = true;
        }
    }

    void Update()
    {
        
    }

    public void AcceptName()
    {
        name = nameInput.text;
        SceneManager.LoadScene("Game");
    }
}

