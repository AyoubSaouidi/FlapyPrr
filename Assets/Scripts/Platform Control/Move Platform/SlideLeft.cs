using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideLeft : MonoBehaviour
{

    public float speed;
    private float groundSize;
    // Start is called before the first frame update
    void Start()
    {
        // GROUND BOX_COLLIDER --> SIZE
        if (gameObject.CompareTag("Ground"))
        {
            groundSize = GetComponent<BoxCollider2D>().size.x;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(
                                 transform.position.x - speed * Time.deltaTime,
                                 transform.position.y);
        // GROUND RE-POSITIONNING
        if (gameObject.CompareTag("Ground"))
        {
            if (transform.position.x < -groundSize)
            {
                transform.position = new Vector2(
                                         transform.position.x + 2 * groundSize,
                                         transform.position.y);
            }
        }

    }
}
