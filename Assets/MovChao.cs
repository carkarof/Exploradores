using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovChao : MonoBehaviour
{
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(vel * Time.deltaTime * Vector2.left);
        if (transform.position.x < -14f)
        {
            transform.position = new Vector2(14f, 0f);
        }
    }
}
