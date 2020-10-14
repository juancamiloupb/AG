using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision destrucCol)
    {
        if (destrucCol.gameObject.tag == "DestrucCol")
        {
            Destroy(destrucCol.gameObject);
            Debug.Log("Ouch");
        }
    }
}
