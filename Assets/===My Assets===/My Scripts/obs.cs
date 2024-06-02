using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour
{
    [Header("Object To Follow")]
    public GameObject Player;
    [Header("The Follower")]
    public GameObject Obs;

    void FixedUpdate()
    {    
        Quaternion lookOnLook =Quaternion.LookRotation(Player.transform.position - transform.position);
        transform.rotation =Quaternion.Slerp(transform.rotation, lookOnLook, Time.deltaTime);
    }
}
