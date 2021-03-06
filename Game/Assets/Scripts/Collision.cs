﻿
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    public Player player;
    
    void Start()
    {
        player = GetComponent<Player>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Enter");
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("TriedToKill");
            player.DamageTheDude(1);
        }

        else if (col.gameObject.tag == "End")
        {
            SceneManager.LoadScene("Win");
        }

        else if (col.gameObject.tag == "Carter")
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}


