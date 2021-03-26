using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EscrevendoTela : MonoBehaviour
{
    public Text txt;
    public string texto;
    public GameObject botao;
   
    void Start()
    {
        StartCoroutine(ditado(texto));        
    }

    void Update()
    {
        
    }


    IEnumerator ditado(string frase)
    {
        int letra = 0;

        while (letra < frase.Length)
        {
            txt.text += frase[letra];
            letra += 1;
            yield return new WaitForSeconds(0.03f);
            
        }        

        botao.SetActive(true);
    }
    

    
}