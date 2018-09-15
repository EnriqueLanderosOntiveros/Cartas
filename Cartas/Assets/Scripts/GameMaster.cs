using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
    public int contCow = 3;
    public int contDog = 3;
    public int contMonkey = 3;
    Cards[] arraycards;
    
    public int number = 3;
    public int clicks;

    public Texture seleccion;

    public Number numero;

    public Cards card1;
    public Cards card2;
    public Cards card3;
    public Cards card4;
    public Cards card5;
    public Cards card6;
    public Cards card7;
    public Cards card8;
    public Cards card9;

    void OnGUI()
    {
        GUILayout.Label(seleccion);
        GUILayout.Label("Seleccion: " + numero.name);
    }

    // Use this for initialization
    void Start () {
        arraycards = new Cards[9];
        arraycards[0] = card1;
        arraycards[1] = card2;
        arraycards[2] = card3;
        arraycards[3] = card4;
        arraycards[4] = card5;
        arraycards[5] = card6;
        arraycards[6] = card7;
        arraycards[7] = card8;
        arraycards[8] = card9;

        for (int i = 0; i < 9; i++)
        {
            float material = Random.Range(0f, 3f);
            if (material < 1)
            {
                if (contDog >0)
                {
                    arraycards[i].RandomDog();
                    contDog--;
                }
                else
                {
                    if (contCow > 0)
                    {
                        
                        arraycards[i].RandomCow();
                        contCow--;
                    }
                    else
                    {
                        
                        arraycards[i].RandomMonkey();
                        contMonkey--;
                    }
                }
                
            }
            if (material < 2 & material > 1)
            {
                if (contCow > 0)
                {
                    arraycards[i].RandomCow();
                    contCow--;
                }

                else
                {
                    if (contDog > 0)
                    {
                        
                        arraycards[i].RandomDog();
                        contDog--;
                    }
                    else
                    {
                        
                        arraycards[i].RandomMonkey();
                        contMonkey--;
                    }
                }


            }
            if (material > 2)
            {
                if (contMonkey > 0)
                {
                    arraycards[i].RandomMonkey();
                    contMonkey--;
                }
                else
                {
                    if (contCow > 0)
                    {
                        arraycards[i].RandomCow();
                        contCow--;
                    }
                    else
                    {
                        arraycards[i].RandomDog();
                        contDog--;
                    }
                }


            }
        }

        if (numero.name == "Uno")
        {
            clicks = 1;
        }
        if (numero.name == "Dos")
        {
            clicks = 2;
        }
        if (numero.name == "Tres")
        {
            clicks = 3;
        }
        Debug.Log(clicks);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
