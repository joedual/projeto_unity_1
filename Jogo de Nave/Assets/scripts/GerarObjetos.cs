using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarObjetos : MonoBehaviour
{
    public GameObject[] arrayDeObjetos;
    public Transform[] arrayDePosicoes;
    public float tempoMaximo;
    public float tempoDeInvocacao;

    // Start is called before the first frame update
    void Start()
    {
        tempoDeInvocacao = tempoMaximo;   
    }

    // Update is called once per frame
    void Update()
    {
        tempoDeInvocacao -= Time.deltaTime;
        if (tempoDeInvocacao<=0)
        {
            InvocarObjetos();
            tempoDeInvocacao = tempoMaximo;
        }
        
    }

    private void InvocarObjetos()
    {
        int objetoAleatorio = Random.Range(0, arrayDeObjetos.Length);
        int posicaoAleatoria = Random.Range(0, arrayDePosicoes.Length);
        Instantiate(arrayDeObjetos[objetoAleatorio], arrayDePosicoes[posicaoAleatoria].position, Quaternion.Euler(0f, 0f, 90f));
    }
}
