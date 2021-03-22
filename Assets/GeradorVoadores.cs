using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorVoadores : MonoBehaviour
{
    public GameObject animal;
    public float contadorTempo = 0;
    public float tempoLimite = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoLimite = Random.Range(2.0f, 80.0f);


        contadorTempo += Time.deltaTime;

        if (contadorTempo >= tempoLimite)
        {
            Instantiate(animal, transform.position, transform.rotation);
            contadorTempo = 0;

        }
    }
}
