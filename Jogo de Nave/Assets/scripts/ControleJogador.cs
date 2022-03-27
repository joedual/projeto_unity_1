using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleJogador : MonoBehaviour
{
    public float velocidadeDaNave;
    public int vida;
    public Rigidbody2D rig;
    private Vector2 comando;
    public Transform localDoDisparoUnico;
    public GameObject laser;
    public bool disparoDuplo;
    public GameObject animacaoExplosao;

    public Slider barraDeVida;

    // Start is called before the first frame update
    void Start()
    {
        barraDeVida.maxValue = vida;
        barraDeVida.value = vida;
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarNave();
        AtirarLaser();
    }

    private void MovimentarNave()
    {
        comando = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rig.velocity = comando.normalized * velocidadeDaNave;
    }

    private void AtirarLaser()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (disparoDuplo == false)
            {
                Instantiate(laser, localDoDisparoUnico.position, localDoDisparoUnico.rotation);
            }
            EfeitosSonoros.instance.somDoLaser.Play();
        }
    }

    public void DanoNaNave(int dano)
    {
        vida -= dano;
        barraDeVida.value = vida;
        EfeitosSonoros.instance.somDeImpactoLaser.Play();
        
        if (vida <= 0)
        {
            barraDeVida.value = 0;
            EfeitosSonoros.instance.somDeExplosao.Play();
            Instantiate(animacaoExplosao, transform.position, transform.rotation);
            Destroy(this.gameObject);
            Debug.Log("Fim de Jogo");
        }
    }
}
