using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    public GameObject Lightning;
    public GameObject LightningA;
    public GameObject LightningB;
    public GameObject LightningC;
    public GameObject LightningD;

    void Start()
    {
        Invoke("SpawnObject", 0.3f);
        Destroy(Lightning, 0.6f);
        Destroy(LightningA, 0.9f);
        Destroy(LightningB, 1.2f);
        Destroy(LightningC, 1.5f);
        Destroy(LightningD, 1.8f);
    }

    void SpawnObject()
    {
        Instantiate(Lightning, new Vector2(3, 2), Quaternion.identity);
        Instantiate(LightningA, new Vector2(3, 2), Quaternion.identity);
        Instantiate(LightningB, new Vector2(3, 2), Quaternion.identity);
        Instantiate(LightningC, new Vector2(3, 2), Quaternion.identity);
        Instantiate(LightningD, new Vector2(3, 2), Quaternion.identity);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            // After 15 seconds, Cancel the Invoked Method with this key |
            //                                                           |
            //                                                           |
            //                                                           \/
            //                                                           X
            CancelInvoke();
        }
    }
}
