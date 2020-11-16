using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer :     MonoBehaviour
{
    public Transform player;
    public float TimeToSearch = 2f;

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            //PlayerSearch();
            return;
        }
        transform.position = new Vector3(player.position.x, player.position.y, -10);


    }

    //void PlayerSearch()
    //{
    //    if(TimeToSearch <= Time.time)
    //    {
    //        GameObject SearcherPlayer = GameObject.FindGameObjectWithTag("Player");
    //        if(SearcherPlayer != null)
    //        {
    //            player = SearcherPlayer.transform;
    //        }
    //        TimeToSearch = Time.time + 0.5f;
    //    }
    //}
}
