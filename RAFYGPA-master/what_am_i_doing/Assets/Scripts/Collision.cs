
using UnityEngine;

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
    }
}


