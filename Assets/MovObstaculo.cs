using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovObstaculo : MonoBehaviour
{
    public float vel;
    public GameObject animal;



    // Start is called before the first frame update
    void Start()
    {
        
        //pontuacao = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -14f)
        {
            Destroy(this.gameObject);
        }

        //if (inimigo.transform.position.x < -7.0f)
        //{
        //inimigo.transform.position = new Vector2(4.0f, Random.Range(-2.5f, 2.5f));
        //pontuacao++;
        //textoPontuacao.text = pontuacao.ToString();
        //}

        transform.Translate(vel * Time.deltaTime * Vector2.left);
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
        }
    }
}
