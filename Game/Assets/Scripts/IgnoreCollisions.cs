using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollisions : MonoBehaviour
{
    public GameObject second;

    void Update()
    {
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), second.GetComponent<Collider2D>());
    }
    
}
