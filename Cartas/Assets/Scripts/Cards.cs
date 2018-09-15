using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cards : MonoBehaviour {
    public Material cowMaterial;
    public Material monkeyMaterial;
    public Material dogMaterial;
    


    
    
    // Use this for initialization
    void Start() {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    private void ChangeColor()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        
    }

    private void OnMouseDown()
    {
        this.ChangeColor();
    }

    public void RandomDog()
    {
            gameObject.GetComponent<Renderer>().material = dogMaterial;
    }

    public void RandomCow()
    {
            gameObject.GetComponent<Renderer>().material = cowMaterial;
    }

    public void RandomMonkey()
    {
            gameObject.GetComponent<Renderer>().material = monkeyMaterial;
    }

}
