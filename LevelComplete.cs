using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagment;

public class LevelComplete : MonoBehaviour {

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}