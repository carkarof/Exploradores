using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarFase1 : MonoBehaviour
{

    float contador = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contador += Time.deltaTime;
       
        if (contador >= 10f)
        {
           SceneManager.LoadScene("CenaSavana");
        }
        
    }
}
