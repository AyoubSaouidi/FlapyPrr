using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] 
    private float minY = -1.25f;
    [SerializeField] 
    private float maxY = 3.25f;
    [SerializeField]
    private float spawnTime = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",spawnTime,spawnTime);
    }

    void Spawn()
	{
        // Get the Pooled Object that we Will Spaw,
        GameObject obj = ObjectPooler.instance.GetPooledObject();
        // IF thre's No GameObject Pooled then we Can't Spawn
        if (obj == null) return;
        // RE_POSITION of the Pooled OBJECT
        float randomY = Random.Range(minY,maxY);
        Vector2 spawnPosition = new Vector2(transform.position.x, randomY);
        obj.transform.position = spawnPosition;
        obj.transform.rotation = transform.rotation;
        //SET Active (Enable the Object)
        obj.SetActive(true);
	}
}
