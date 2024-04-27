using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolenColision : MonoBehaviour
{

    public int points;

    private GameObject thisObject; //para colocar o game object atual numa variavel
    void Start()
    {
        thisObject = gameObject; //define o game objeto atual como this object
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            thisObject.gameObject.SetActive(false); //desativa o game object
            Pontuacao.score = Pontuacao.score + points;
        }
    }

}

