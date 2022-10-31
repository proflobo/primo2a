using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    List<Collider> colliders = new List<Collider>();
    void Start()
    {
      
    }

    void OnCollisionEnter(Collision collision)
    {        
        if (collision.gameObject.tag == "Enemy")//gameObject.name == "Enemy"
        {
            Destroy(collision.gameObject);
           
        }
        else
        {
            Destroy(gameObject, 5);
        }
        
    }   
    /*void Awake()
    {
        Destroy(gameObject, 5);
    }*/
}
