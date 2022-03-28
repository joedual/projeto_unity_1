using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool pausado;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Pausar();   
    }

    void Pausar()
    {
        if (Input.GetKeyDown(KeyCode.P) && pausado==true)
        {
            Time.timeScale = 1;
            pausado = false;
        } else if(Input.GetKeyDown(KeyCode.P) && pausado == false)
        {
            Time.timeScale = 0;
            pausado = true;
        }
    }

}
