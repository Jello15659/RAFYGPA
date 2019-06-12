using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [System.Serializable]
    public class PlayerStats
    {
        // Start is called before the first frame update
        public int health = 1;

    }
    public PlayerStats playerStats = new PlayerStats();
    public int deathZone = -20;
    public Transform spawnPoint;
    public float deathDelay = 0.5f;
    public bool invincible = false;
    public GameObject gpa, four, three, two, one;

    public IEnumerator DamagePlayer(int damage)

    {
        if (!invincible)
        {


            playerStats.health -= damage;
            Debug.Log("damaged");
            switch (playerStats.health)
            {
                case 4:
                    four.gameObject.SetActive(true);
                    three.gameObject.SetActive(false);
                    two.gameObject.SetActive(false);
                    one.gameObject.SetActive(false);
                    break;

                case 3:
                    four.gameObject.SetActive(false);
                    three.gameObject.SetActive(true);
                    two.gameObject.SetActive(false);
                    one.gameObject.SetActive(false);
                    break;

                case 2:
                    four.gameObject.SetActive(false);
                    three.gameObject.SetActive(false);
                    two.gameObject.SetActive(true);
                    one.gameObject.SetActive(false);
                    break;

                case 1:
                    four.gameObject.SetActive(false);
                    three.gameObject.SetActive(false);
                    two.gameObject.SetActive(false);
                    one.gameObject.SetActive(true);
                    break;

                default:
                    four.gameObject.SetActive(false);
                    three.gameObject.SetActive(false);
                    two.gameObject.SetActive(false);
                    one.gameObject.SetActive(false);
                    //INSERT GAME OVER
                    break;



            }
            if (playerStats.health <= 0)
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
            invincible = true;

            yield return new WaitForSeconds(2);
            invincible = false;
        }
    }


    void Update()
    {
        if (transform.position.y <= deathZone)
        {
            StartCoroutine(DamagePlayer(9999));
        }

    }



    public IEnumerator KillPlayer()
    {
        GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(deathDelay);
        GetComponent<Renderer>().enabled = true;
        transform.position = spawnPoint.transform.position;

    }
}
