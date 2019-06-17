using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject pencil;
    float randX;
    //private Rigidbody2D pencilBody;
    Vector2 whereToSpawn;
    public float spawnRate = 0.5f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //pencilBody = pencilThing.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //if (Time.time > nextSpawn)
        //{
        //    GameObject clone;
        //    nextSpawn = Time.time + spawnRate;
        //    randX = Random.Range(0.0f, 17.0f);
        //    whereToSpawn = new Vector2(230.0f, randX);
        //    clone = Instantiate(pencil, whereToSpawn, Quaternion.identity);
        //    Transform optimus = clone.GetComponent<Transform>();
        //    optimus.position = Vector2.MoveTowards(optimus.position, new Vector2(-50.0f, optimus.position), 4 * Time.deltaTime);

        //}
    }
}
