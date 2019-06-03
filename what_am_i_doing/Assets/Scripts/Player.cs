using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStats
    {
        // Start is called before the first frame update
        public int health = 100;
    }
    public PlayerStats playerStats = new PlayerStats();
    public int deathZone = -20;
    public Transform spawnPoint;

    public void DamagePlayer(int damage)
    {
        playerStats.health -= damage;

        if(playerStats.health <= 0)
        {
            //GameMaster.KillPlayer(this);
            transform.position = spawnPoint.transform.position;
        }
    }

    void Update()
    {
        if (transform.position.y <= deathZone)
        {
            DamagePlayer(9999);
        }
    }
}
