using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int pontuacao;
    public Text textoDePontuacao;

    void Awake()
    {
        instance = this;    
    }

    public void Start()
    {
        pontuacao = 0;
        textoDePontuacao.text = "" + pontuacao;
    }

    public void IncrementoPontos(int pontos)
    {
        pontuacao += pontos;
        textoDePontuacao.text = ""+pontuacao;
    }
}
