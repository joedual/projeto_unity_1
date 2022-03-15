using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInimigo : MonoBehaviour
{
    public float velocidadeDaNave;
    public int vidaDaNave;
    public Transform localDoDisparo;
    public GameObject laser;
    public float tempoMaximoEntreOsLasers;
    public float tempoAtualDoLaser;
    public bool atirador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarNave();   
    }

    private void MovimentarNave()
    {
        transform.Translate(Vector3.up * velocidadeDaNave * Time.deltaTime);
        if (atirador==true)
        {
            dispararLaser();
        }
    }

    private void dispararLaser()
    {
        tempoAtualDoLaser -= Time.deltaTime;
        if (tempoAtualDoLaser <= 0)
        {
            Instantiate(laser, localDoDisparo.position, Quaternion.Euler(0f, 0f, 90f));
            tempoAtualDoLaser = tempoMaximoEntreOsLasers;
        }
    }

    public void DanoNaNave(int dano)
    {
        vidaDaNave -= dano;
        if (vidaDaNave <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
