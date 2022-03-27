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
    public bool laserAtivado;
    public GameObject animacaoExplosao;
    // Start is called before the first frame update
    void Start()
    {
        laserAtivado = false;
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

    public void AtivarLaser()
    {
        laserAtivado = true;
    }

    private void dispararLaser()
    {
        tempoAtualDoLaser -= Time.deltaTime;
        if (tempoAtualDoLaser <= 0 && laserAtivado == true)
        {
            Instantiate(laser, localDoDisparo.position, Quaternion.Euler(0f, 0f, 90f));
            tempoAtualDoLaser = tempoMaximoEntreOsLasers;
        }
    }

    public void DanoNaNave(int dano)
    {
        vidaDaNave -= dano;
        EfeitosSonoros.instance.somDeImpactoLaser.Play();
        if (vidaDaNave <= 0)
        {
            EfeitosSonoros.instance.somDeExplosao.Play();
            Instantiate(animacaoExplosao, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ControleJogador>().DanoNaNave(100);
            EfeitosSonoros.instance.somDeExplosao.Play();
            Instantiate(animacaoExplosao, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
