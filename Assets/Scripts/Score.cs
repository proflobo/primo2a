using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public string score;
    public Text scoreText;
    //public int QuantidadedeMortes;
    void Start()
    {

    }
    void Update()
    {
        scoreText.text = score.ToString();
        //TextoMortes.text = (QuantidadedeMortes.ToString());
    }
}