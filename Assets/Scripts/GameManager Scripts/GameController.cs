using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public static GameController instance;
    public GameObject losePanel;

	private void Awake()
	{
        instance = this;
	}
	// Start is called before the first frame update
	void Start()
    {
        if (SceneManager.GetActiveScene().name == "FlappyBird")
        {
            losePanel.SetActive(false);
            ReleaseTime();
        }
    }

    public void Lose()
	{
        FreezTime();
        losePanel.SetActive(true);
	}

    void FreezTime()
	{
        Time.timeScale = 0.0f;
	}

    void ReleaseTime()
	{
        Time.timeScale = 1.0f;
	}

    public void Restart()
	{
        SceneManager.LoadScene("FlappyBird");
	}

    public void Home()
    {
        SceneManager.LoadScene("Home");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
