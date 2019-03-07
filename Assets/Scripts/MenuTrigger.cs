using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "StartGame")
        {
            SceneManager.LoadScene("TestRoom");
        }
        else if(other.tag == "QuitGame")
        {
            Application.Quit();
        }
    }
}
