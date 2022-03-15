using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserInimigo : MonoBehaviour
{
    public float velocidade;
    public int dano;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movimentar();
    }

    private void Movimentar()
    {
        transform.Translate(Vector3.up * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<ControleJogador>().DanoNaNave(dano);
            Destroy(this.gameObject);
        }
    }
}
