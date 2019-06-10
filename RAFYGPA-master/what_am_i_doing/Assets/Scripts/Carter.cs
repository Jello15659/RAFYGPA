using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carter : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private float velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = speed;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(velocity * Time.deltaTime, 0f);
    }
}
