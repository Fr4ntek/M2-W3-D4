using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio3 : MonoBehaviour
{
    public string phrase;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!string.IsNullOrEmpty(phrase))
        {
            if(phrase.IndexOf('(') != -1 && phrase.IndexOf(')') != 1)
            {
                string phraseTrimmed = phrase.Trim('(', ')');
                string[] phraseSplitted = phraseTrimmed.Split(';', ')');
                for (int i = 0; i < phraseSplitted.Length; i++)
                {
                    Debug.Log(phraseSplitted[i]);
                }  
            } 
            else
            {
                Debug.Log("Errore: Controlla di aver inserito entrambe le parentesi ()");
                Debug.Log("La stringa dev essere (bla;bla;bla) frase");
            }
        }
        else
        {
            Debug.Log("Attenzione: la stringa è vuota");
        }
      
    }

    // Update is called once per frame
    void Update()
    {

    }

}
