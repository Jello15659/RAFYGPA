using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPencil : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Debug.Log("Destroy");
            Destroy(transform);
        }
    }
}
