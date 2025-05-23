using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExampleScript : MonoBehaviour // kurang monobehaviour
{

    private Rigidbody pj; //explain this

    void Start()
    {
		    pj = GetComponent<Rigidbody>(); //explain this
        Invoke("lpj", 2.0f);  //explain this
    }

    void lpj()
    {
        Rigidbody instance = Instantiate(pj);//explain this
        instance.velocity = Random.insideUnitSphere * 5.0f; //explain this
    }
}
