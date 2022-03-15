using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivadorDoLaserDeInimigo : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Inimigo"))
        {
            collision.gameObject.GetComponent<ControleInimigo>().AtivarLaser();
        }
    }

}
