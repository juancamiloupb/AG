using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilAleatorio : MonoBehaviour
{
    public GameObject Misiles;
    public float tiempodecreacion = 4f, RangoCreacion = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Creando", 0.0f, tiempodecreacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Creando()
    {
        Vector3 SpawnPosition = new Vector3(0, 0, 0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawnPosition = new Vector3(SpawnPosition.x, this.transform.position.y, 0);

        GameObject Misil = Instantiate (Misiles, SpawnPosition, Quaternion.identity);

    }

}
