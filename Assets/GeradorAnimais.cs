using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorAnimais : MonoBehaviour
{
    public GameObject animal;
    public GameObject animal1;
    public GameObject animal2;    
    public float contadorTempo = 0;
    private float tempoLimite = 0;
    public float tempoLimiteA = 0;
    public float tempoLimiteB = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoLimite = Random.Range(tempoLimiteA, tempoLimiteB);
        

        contadorTempo += Time.deltaTime;

        if (contadorTempo >= tempoLimite)
        {
            int aleatorio = Random.Range(1, 3);
            
            switch (aleatorio)
            {
                case 1:
                    animal = animal1;
                    break;
                case 2:
                    animal = animal2;
                    break;
            }
            Instantiate(animal, transform.position, transform.rotation);
            
            contadorTempo = 0;

        }
    }
}
