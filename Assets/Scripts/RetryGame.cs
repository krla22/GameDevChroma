using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{

    void Update()
    {
        
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
