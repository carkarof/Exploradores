using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float vel;
    public Rigidbody2D _rigid2d;
    public GameObject player;
    public GameObject animal;
    public int pontuacao;          
    public Animator Animador;
    public Text textoPontuacao;       
    public Text textoPontuacaoDesviados;       
    public float tAtaque;
    public float tSemAtaque;
    public GameObject TxtGameOver;
    public bool Vivo = true;
    public AudioSource sfxPulo;
    public AudioSource sfxAtaque;
    public AudioSource sfxBackground;
    public AudioSource sfxGameOver;
    public string cena;
    



    // Start is called before the first frame update
    void Start()
    {
        
        pontuacao = 0 ;
        sfxBackground.Play();
        _rigid2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        cena = SceneManager.GetActiveScene().name;

        if (cena == "CenaSavana")
        {
            if (pontuacao == 15  )
            {
                SceneManager.LoadScene("CenaSelva");
            }
        }else if(cena == "CenaSelva" )
        {
            if(pontuacao == 15 && textoPontuacaoDesviados.text != "0" || 
                pontuacao == 15 && textoPontuacaoDesviados.text == "0")
            {
                SceneManager.LoadScene("CenaCreditos");
            }
        }

       
        if (Vivo == false)
        {
            Debug.Log(Vivo);
            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("CenaSavana");
            }
        }
        //if (Animador.GetCurrentAnimatorStateInfo(0).IsName("andando"))
        //{
        //    Debug.Log("funcionou!");
        //}

        // botao esquerdo do mouse, detecta um clique no smartphone
        if (player.transform.position.y <= 2.1)
        {
            //Animador.SetBool("noPulo", false);
            if (Input.GetKey("space"))
            {   
                Animador.SetTrigger("noPulo");
                sfxPulo.Play();
                _rigid2d.velocity = Vector2.up * vel;
            }
           
        }

        //pressione para atacar
        if (Input.GetKeyDown(KeyCode.P))
        {
            
            Animador.SetTrigger("noAtaque");

            //float distancia = Vector3.Distance(transform.position, animal.transform.position);
            
            sfxAtaque.Play();
            //if (Animador.GetCurrentAnimatorStateInfo(0).IsName("atacando") && distancia < 2.5)
            //{
            //    Debug.Log("Acertou o bicho");

            //}


        }       
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "animal" && Animador.GetCurrentAnimatorStateInfo(0).IsName("atacando"))
        {
            //SceneManager.LoadScene("");
            pontuacao++;
            textoPontuacao.text = pontuacao.ToString();
           
            Debug.Log("Matou bicho");
        }
        else if(collision.gameObject.tag == "animal" && !Animador.GetCurrentAnimatorStateInfo(0).IsName("atacando"))
        {
            Time.timeScale = 0;
            TxtGameOver.SetActive(true);
            Vivo = false;
            sfxBackground.mute = true ;
            sfxGameOver.Play();            
            Debug.Log("animal matou o player");
        }        

    }

    

    
}
