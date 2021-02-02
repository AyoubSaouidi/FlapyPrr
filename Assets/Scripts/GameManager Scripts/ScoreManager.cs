using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public Text scoreText;
	private int score;

	private void Awake()
	{
		instance = this;
	}
	// Start is called before the first frame update
	void Start()
    {
        score = 0;
    }

	public void scoreUp()
	{
        score++;
        scoreText.text = score.ToString();
	}
}
