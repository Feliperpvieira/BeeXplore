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
    public GameObject lostScreen;
    public GameObject botoes;
    public TMP_Text winTitle;

    public float totalTime;
    public TMP_Text countdownText;
    private float minutes;
    private float seconds;

    void Start()
    {
        score = 0; //Reseta a contagem no início de partidas
        victoryScreen.SetActive(false);
        lostScreen.SetActive(false);
        scoreText.enabled = true;
        barraPolen.enabled = true;
        botoes.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Update()
    {
       scoreText.text = score.ToString();
        GetCurrentFill();

        totalTime -= 1 * Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);
        countdownText.text = minutes.ToString() + ":" + seconds.ToString("00");

        if (totalTime <= 0)
        {
            totalTime = 0;
            if (score >= (scoreToWin * 70 / 100))
            {
                Victory(70);
            }
            else
            {
                Lost();
            }
        }

        if (score >= scoreToWin)
        {
            Victory(100);
        }

    }

    public void StartGame()
    {
        Time.timeScale = 1f;
    }

    void GetCurrentFill() // Funcao que faz passar o tempo na barra de progresso, ao lado do cronometro
    {
        float fillAmount = (float)score / (float)scoreToWin;
        barraPolen.fillAmount = fillAmount;
    }

    void Victory(int total)
    {
        Time.timeScale = 0f;
        victoryScreen.SetActive(true);
        if(total == 70)
        {
            winTitle.text = "Well... You helped the bees!";
        }else if(total == 100)
        {
            winTitle.text = "You saved the bees!";
        }

        scoreText.enabled = false;
        barraPolen.enabled = false;
        botoes.SetActive(false);
    }

    void Lost()
    {
        Time.timeScale = 0f;
        lostScreen.SetActive(true);
        scoreText.enabled = false;
        barraPolen.enabled = false;
        botoes.SetActive(false);
    }
}

