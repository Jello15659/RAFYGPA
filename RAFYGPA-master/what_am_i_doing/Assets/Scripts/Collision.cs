﻿
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Player player;
    
    void Start()
    {
        player = new Player();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Enter");
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("TriedToKill");
            player.DamagePlayer(1);
        }
    }
}


