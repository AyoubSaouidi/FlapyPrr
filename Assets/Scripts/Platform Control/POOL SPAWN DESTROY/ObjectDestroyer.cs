using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    [SerializeField]
    private float destroyTime = 3.0f;

    // "Enable" is called When we Enable the GameObject
    void OnEnable()
    {
        Invoke("DestroyObject", destroyTime);
    }

    // Set gameObject Active to False (Disabling The GameObject)
    void DestroyObject()
	{
        gameObject.SetActive(false);
    }

    // "Disable" is called When we Disable the GameObject
    void OnDisable()
    {
        CancelInvoke();
    }
}
