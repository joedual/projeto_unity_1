using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioInfinito : MonoBehaviour
{
    public float velocidadeDoCenario;
  
    // Update is called once per frame
    void Update()
    {
        MovimentarCernario();
    }

    private void MovimentarCernario()
    {
        Vector2 deslocamento = new Vector2(Time.time * velocidadeDoCenario, 0f);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;

    }
}
