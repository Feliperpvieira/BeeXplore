using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolenColision : MonoBehaviour
{

    public int points; //quantos pontos essa flor dá
    [Header("Partículas emitidias")]
    public GameObject particulasPontos; //particulas a serem emitidas quando a flor é pega
    private bool alreadyCollected = false; //usado pra saber se a flor já foi coletada ou nao

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && alreadyCollected == false)
        {
            Instantiate(particulasPontos, transform.position, Quaternion.identity);

            //gameObject.SetActive(false); //desativa o game object atual
            gameObject.GetComponent<Outline>().enabled = false; //desativa o outline

            Pontuacao.score = Pontuacao.score + points;
            alreadyCollected = true;
        }
    }

}

