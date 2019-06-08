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
    public float deathDelay = 0.5f;
    public void DamagePlayer(int damage)
    {
        playerStats.health -= damage;
        Debug.Log("damaged");
        if(playerStats.health <= 0)
        {
            Debug.Log("less health");
            StartCoroutine(KillPlayer());
            //GameMaster.KillPlayer(this);
            //transform.position = new Vector3(-999f, -999f, -999f);
            //GetComponent<Renderer>().enabled = false;
            //yield return new WaitForSeconds(deathDelay);
            //transform.position = spawnPoint.transform.position;
            //GetComponent<Renderer>().enabled = true;
        }
    }


    void Update()
    {
        if (transform.position.y <= deathZone)
        {
            DamagePlayer(9999);
        }

    }

    //void OnTriggerEnter(Collider col)
    //{
    //    if (col.tag == "Enemy")
    //    {
    //        DamagePlayer(1);
    //    }
    //}

    public IEnumerator KillPlayer()
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(deathDelay);
        GetComponent<Renderer>().enabled = true;
        transform.position = spawnPoint.transform.position;

    }
}
