using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float fireDileat = 10;

    // Update is called once per frame
    void Update()
    {
        fireDileat -= 0.1f;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && fireDileat <= 0.0f)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            fireDileat = 10f;
        }
    }
}
