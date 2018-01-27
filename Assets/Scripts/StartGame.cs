using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour {

    public GameObject MenuPan;
    public GameObject Level1Pan;

	public void LoadFirstPanel()
    {
        MenuPan.SetActive(false);
        Level1Pan.SetActive(true);
    }

    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
