using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirComTempo : MonoBehaviour
{
    public float tempoDeDuracao;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, tempoDeDuracao);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
