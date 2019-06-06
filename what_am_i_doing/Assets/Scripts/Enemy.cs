using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform target;
    public Player player = new Player();
    //public PlayerStats playerStats = new PlayerStats();

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null)
        {
            return;
        }
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //if (col.tag == "Player")
        //{
        //    playerStats.health = playerStats - 1;
        //}
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            player.DamagePlayer(1);
            Debug.Log("Called");
        }
    }
}
