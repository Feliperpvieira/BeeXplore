using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolenColision : MonoBehaviour
{

    public int points;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false); //desativa o game object atual
            Pontuacao.score = Pontuacao.score + points;
        }
    }

}

