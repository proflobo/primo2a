using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public score SC;

    void Start()
    {
        SC = GameObject.Find("TextoMortes").GetComponent<TextoMortes>();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (collision.gameObject.tag == "Bala")//gameObject.name == "Enemy"
        {
      
            SC.score += 1;

        }
    }
}
