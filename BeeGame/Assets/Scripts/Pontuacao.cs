using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Pontuacao : MonoBehaviour
{
    public static int score; //pontuacao atual
    public int scoreToWin; //max value, pontuacao pra ganhar a fase
    public TMP_Text scoreText; //Pontuacao do jogador
    public Image barraPolen;
    public GameObject victoryScreen;
    public GameObject botoes;

    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
        victoryScreen.SetActive(false);
        scoreText.enabled = true;
        barraPolen.enabled = true;
        botoes.SetActive(true);
    }

    public void Update()
    {
        scoreText.text = score.ToString();
        GetCurrentFill();

        if(score >= scoreToWin)
        {
            victoryScreen.SetActive(true);
            scoreText.enabled = false;
            barraPolen.enabled = false;
            botoes.SetActive(false);
        }

    }

    void GetCurrentFill() // Funcao que faz passar o tempo na barra de progresso, ao lado do cronometro
    {
        float fillAmount = (float)score / (float)scoreToWin;
        barraPolen.fillAmount = fillAmount;
    }
}
