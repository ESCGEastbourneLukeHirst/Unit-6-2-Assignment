using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindrops2 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            if (gameObject.GetComponent<ParticleSystem>().isPlaying == true)
            {
                gameObject.GetComponent<ParticleSystem>().Stop();
            }
            else
            {
                gameObject.GetComponent<ParticleSystem>().Play();
            }
    }
}
