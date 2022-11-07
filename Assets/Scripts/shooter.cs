using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shooter : MonoBehaviour
{
    public Rigidbody obj_shooter;
    public Transform pos_origem;
    void Start()
    {
        
    }
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody shooter_instance;
            shooter_instance = Instantiate(obj_shooter, pos_origem.position, pos_origem.rotation) as Rigidbody;
            shooter_instance.AddForce(pos_origem.forward * 300);
           
        }  
    }
}
