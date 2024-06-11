using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGameLegacy()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }


    public void PlayGameBIGBIG()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
