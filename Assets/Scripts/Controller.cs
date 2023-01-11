using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Rigidbody player;

    public GameObject Lightning;

    public void Start()
    {
        player = GetComponent<Rigidbody>();

        StartCoroutine(WaitBeforeNext());
    }
    private IEnumerator WaitBeforeNext()
    {
            if (Input.GetKeyDown(KeyCode.L))
            {
                GameObject clone;
                clone = Instantiate(Lightning);
                clone.transform.position = player.transform.position;

            yield return new WaitForSeconds(5f);
            StopCoroutine(WaitBeforeNext());
        }
    }
}
