using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    public enum DAMAGE_TYPE
    {
        SLASHING, PIERCING, BLUDGEONING, MAGICAL, FORCE
    }

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistance;
    public DAMAGE_TYPE weakness;
    public int baseDamage;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Danno iniziale: " + baseDamage);
        Debug.Log("Tipo di Attacco: " + attackType.ToString());
        Debug.Log("Nemico resistente a: " + resistance.ToString());
        Debug.Log("Nemico debole a: " + weakness.ToString());

        if (attackType.Equals(resistance)){
            baseDamage /= 2;
            Debug.Log("Attenzione: il nemico è resistente agli attacchi di tipo: " + attackType.ToString());
            Debug.Log("Nuovo danno: " + baseDamage);        
        }

        if (attackType.Equals(weakness))
        {
            baseDamage *= 2;
            Debug.Log("Attenzione: il nemico è debole agli attacchi di tipo: " + attackType.ToString());
            Debug.Log("Nuovo danno: " + baseDamage);
        }

        Debug.Log("Danno finale: " + baseDamage);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
