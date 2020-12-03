using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOnLine : MonoBehaviour
{
    public GameObject[] GOArray;
    void Start()
    {
        var temp = GOArray[0].transform.position;

        foreach (var Go in GOArray)
        {
            Go.gameObject.transform.position = temp;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
