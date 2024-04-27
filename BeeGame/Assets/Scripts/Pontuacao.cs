using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Pontuacao : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText; //Pontuacao do jogador

    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
    }

    public void Update()
    {
        scoreText.text = score.ToString();
    }

    //void Replace(GameObject state1, GameObject state2)
    //{
    //    Instantiate(state2, state1.transform.position, Quaternion.identity);
    //    Destroy(state1);
    //}
}
