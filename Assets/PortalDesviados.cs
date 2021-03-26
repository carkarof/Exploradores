using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PortalDesviados : MonoBehaviour
{

    public int pontuacaoDesviados;
    public Text textoPontuacaoDesviados;
    public Text textoPontuacao;
    public string cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        cena = SceneManager.GetActiveScene().name;
        
        if (cena == "CenaSavana")
        {
            if (pontuacaoDesviados == 5 && textoPontuacao.text=="0")
            {
                SceneManager.LoadScene("CenaSelva Desviados");
            }
        
        }else if(cena == "CenaSelva Desviados")
        {
            if(pontuacaoDesviados == 5 && textoPontuacao.text == "0")
            {
                SceneManager.LoadScene("CenaCreditos Feliz");
            }else if (textoPontuacao.text == "15")
            {
                SceneManager.LoadScene("CenaCreditos");
            }           
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "animal")
        {

            pontuacaoDesviados++;
            textoPontuacaoDesviados.text = pontuacaoDesviados.ToString();
            
        }
    }




}
