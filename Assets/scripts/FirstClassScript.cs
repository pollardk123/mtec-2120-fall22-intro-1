using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstClassScript: MonoBehaviour


{ Renderer rend;
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        rend.material.color = GetRandomColor(); 
       
    }

    Color GetRandomColor()
    {

        return new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    } 
}
