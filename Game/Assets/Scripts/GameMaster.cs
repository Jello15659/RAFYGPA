﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    public static GameMaster gm;

    public Transform playerPrefab;
    public Transform spawnPoint;
    //public int waitTime = 1;
    void Start()
    {
        if(gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }
    } 

    public void RespawnPlayer()
    {
        //yield return new WaitForSeconds(waitTime);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
    }
    // Start is called before the first frame update
    public static void KillPlayer(Player player)
    {
        Destroy(player.gameObject);
        gm.RespawnPlayer();

    }
}
