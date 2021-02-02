using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public static ObjectPooler instance;
    public GameObject pooledObject;
    public int pooledAmount;
    List<GameObject> pooledObjects;
    public bool willGrow=false;

	private void Awake()
	{
		instance = this;
	}
	// Start is called before the first frame update
	void Start()
    {
        pooledObjects = new List<GameObject>();//Creating Empty List for pooling our Object
		for (int i=0 ; i<pooledAmount ; i++)
		{ //Adding the Desired Amount of the GameObject
            GameObject obj = (GameObject)Instantiate(pooledObject);
            obj.SetActive(false); //Set gameObject to False ( We will Enable it When we Need it )
            pooledObjects.Add(obj); 
		}
        
    }

    public GameObject GetPooledObject()
	{
        // RUN the List of Pooled Objects and Check if they are Setted To False
		for (int i=0 ; i < pooledObjects.Count ; i++)
		{
			if (!pooledObjects[i].activeInHierarchy)
			{
                return pooledObjects[i];
			}
		}
        //If there's No Pooled Objects in the Pool(List) we Add more [willGrow = true]
		if (willGrow)
		{
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
		}
        return null;
	}
}
