using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderOnLine : MonoBehaviour
{
    Collider m_Collider;
    Vector3 m_Center;
    Vector3 m_Size, m_Min, m_Max;
    private Vector3 stored;
    public GameObject[] GOArray;
    private float kk;
    void Start()
    {
       var temp = GOArray[0].gameObject.transform.position;
        stored = new Vector3(0,0,0);
        
        //Fetch the Collider from the GameObject
        m_Collider = GetComponent<Collider>();
        //Fetch the center of the Collider volume
        m_Center = m_Collider.bounds.center;
        //Fetch the size of the Collider volume
        m_Size = m_Collider.bounds.size;
        //Fetch the minimum and maximum bounds of the Collider volume
        m_Min = m_Collider.bounds.min;
        m_Max = m_Collider.bounds.max;
        //Output this data into the console
        OutputData();
        
        foreach (var Go in GOArray)
        {
            //Go.gameObject.transform.position = 
            var ImpGo = Go.transform.position;
            ImpGo.y = 0;
            ImpGo.x = 0;
            ImpGo.z = kk;
            Go.transform.position = ImpGo;
            kk++;
            


        }
    }
    void OutputData()
    {
        //Output to the console the center and size of the Collider volume
        //Debug.Log("Collider Center : " + m_Center);
        //Debug.Log("Collider Size : " + m_Size);
        Debug.Log("Collider bound Minimum : " + m_Min);
       Debug.Log("Collider bound Maximum : " + m_Max);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
