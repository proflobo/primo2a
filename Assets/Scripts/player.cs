using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed = 200f;
    Animator anim;  // define o animator controler
    void Start()
    {
        //linka o animator com o Animator controle
        anim = GetComponent<Animator>();
    }
        
    void Update(){
        //movimento do player
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);

        //rotação do player
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        //verifica se determinadas teclas estão sendo pressionadas
        if(Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("andando", true);
        }
        else
        {
            anim.SetBool("andando", false);
        }

    }
}
