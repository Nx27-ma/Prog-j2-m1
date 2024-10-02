using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class Pickup : MonoBehaviour
{
    private bool pickuptouch;
    GameObject player;

    void Start(){
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {

        if (Vector3.Distance(transform.position, player.transform.position) < 1.5)
        {
            pickuptouch = true;
        }
        else
        {
            pickuptouch = false;
        }

        if (pickuptouch)
        {
            Canvass.Uevent(Random.Range(0, 3));
            Destroy(gameObject);
        }
        
    }
    
    
}
