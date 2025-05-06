using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    public int numeroMax;
    List<int> list = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numeroMax; i++)
        {
            int posizione = i % 3;

            if(posizione == 0)
            {
                list.Insert(0, i);
            }

            if (posizione == 1)
            {
                list.Add(i);
            }

            if(posizione == 2)
            {
                int meta = list.Count / 2;
                list.Insert(meta, i);
            }
            Debug.Log("Contenuto lista: " + string.Join(", ", list));
            //for (int  j = 0; j < list.Count; j++)
            //{
            //    Debug.Log(list[j]);
            //}

        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }

}
