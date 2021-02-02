using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
		{
            Touch firstTouch = Input.touches[0];
			if (firstTouch.phase == TouchPhase.Began)
			{
                //Flap
                rb.velocity = Vector2.up * speed; // (0.0f,1.0f) UP
            }
		}
#if UNITY_EDITOR
		if (Input.GetMouseButtonDown(0))
		{
            //Flap
            rb.velocity = Vector2.up * speed; // (0.0f,1.0f) UP
		}
#endif
    }

	private void OnTriggerEnter2D(Collider2D other)
	{
        if(other.gameObject.CompareTag("Column"))
		{
            ScoreManager.instance.scoreUp();
        }
	}

    private void OnCollisionEnter2D(Collision2D hit)
    {
        switch (hit.gameObject.tag)
        {
            case "Tube":
                GameController.instance.Lose();
                break;
            case "Ground":
                GameController.instance.Lose();
            break;
        }
    }
}
