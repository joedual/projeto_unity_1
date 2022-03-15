using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleJogador : MonoBehaviour
{
    public float velocidadeDaNave;
    public Rigidbody2D rig;
    private Vector2 comando;
    public Transform localDoDisparoUnico;
    public GameObject laser;
    public bool disparoDuplo;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        {

        }
    }
}
