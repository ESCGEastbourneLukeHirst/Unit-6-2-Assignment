using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody player;

    public GameObject Lightning;
    public GameObject LightningA;
    public GameObject LightningB;
    public GameObject LightningC;
    public GameObject LightningD;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKey("l"))
            {
            GameObject clone;
                clone = Instantiate(Lightning);
                clone.transform.position = player.transform.position;

                clone = Instantiate(LightningA);
                clone.transform.position = player.transform.position;

                clone = Instantiate(LightningB);
                clone.transform.position = player.transform.position;

                clone = Instantiate(LightningC);
                clone.transform.position = player.transform.position;

                clone = Instantiate(LightningD);
                clone.transform.position = player.transform.position;
        }
        }
}
