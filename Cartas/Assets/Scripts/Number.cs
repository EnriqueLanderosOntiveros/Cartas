using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour {
    public Material uno;
    public Material dos;
    public Material tres;

    // Use this for initialization
    void Start () {
        float numero = Random.Range(0f, 3f);
        

        if (numero <= 1f)
        {
            gameObject.GetComponent<Renderer>().material = uno;
            gameObject.name = "Uno";
        }

        if (numero <= 2f & numero > 1f)
        {
            gameObject.GetComponent<Renderer>().material = dos;
            gameObject.name = "Dos";
        }

        if (numero > 2f)
        {
            gameObject.GetComponent<Renderer>().material = tres;
            gameObject.name = "Tres";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
