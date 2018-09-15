using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMain : MonoBehaviour {
    public Material cowMaterial;
    public Material monkeyMaterial;
    public Material dogMaterial;


    // Use this for initialization
    void Start()
    {
        float material = Random.Range(0f, 3f);
        

        if (material <= 1f)
        {
            gameObject.GetComponent<Renderer>().material = dogMaterial;
        }

        if (material <= 2f & material > 1f)
        {
            gameObject.GetComponent<Renderer>().material = cowMaterial;
        }

        if (material > 2f)
        {
            gameObject.GetComponent<Renderer>().material = monkeyMaterial;
        }
    }


    // Update is called once per frame

    void Update () {
		
	}
}
