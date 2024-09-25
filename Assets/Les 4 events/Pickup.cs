using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class Pickup : MonoBehaviour
{
    private int layermasked;
    private RaycastHit hit;
    private bool pickuptouch;
    void Start(){
        layermasked = LayerMask.GetMask(new string[] {"Player"});
    }

    // private void OnDrawGizmos()
    // {
    //     Gizmos.DrawSphere(transform.position, 2f);
    // }

    // Update is called once per frame

    private void FixedUpdate()
    {
        pickuptouch = Physics.SphereCast(transform.position, 6f, Vector3.fwd, out hit, 0.1f, layermasked);
    }

    void Update()
    {
        
        
        if (pickuptouch)
        {
            
            Debug.Log("pickup   "); 
            Debug.Log(hit.collider.gameObject.name);
            Canvass.Uevent(Random.Range(0, 3));
            Destroy(gameObject);
        }
        
    }
    
    
}
