using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovVoadores : MonoBehaviour
{
    public GameObject animal;    
    private Vector3 mudaraltura;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {        
        
        if (animal.transform.localScale.y > 2.0f || animal.transform.localScale.y < 10.0f) {
            mudaraltura = -mudaraltura;
        }
        
    }

    
}
