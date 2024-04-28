using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolenColision : MonoBehaviour
{

    public int points;
    [Header("Partículas emitidias")]
    public GameObject particulasPontos;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Instantiate(particulasPontos, transform.position, Quaternion.identity);

            gameObject.SetActive(false); //desativa o game object atual
            Pontuacao.score = Pontuacao.score + points;
        }
    }

}

