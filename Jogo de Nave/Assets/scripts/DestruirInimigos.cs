using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirInimigos : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Inimigo"))
        {
            Destroy(collision.gameObject);
        }
    }
}
