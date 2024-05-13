using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColision : MonoBehaviour
{
    public int points; //quantos pontos essa flor dá
    //public string falaRegina;
    //public GameObject falaDaReginaUI;
    [Header("Partículas emitidias")]
    public GameObject particulasPontos; //particulas a serem emitidas quando a flor é pega

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(particulasPontos, transform.position, Quaternion.identity);
            
            Pontuacao.score = Pontuacao.score + points;
        }
    }
}
