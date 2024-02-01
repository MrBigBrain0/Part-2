using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSpawner : MonoBehaviour
{

    float spawnTimer;
    public GameObject Plane;
    Vector3 spawn;
    Vector4 rota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += 1f * Time.deltaTime;
        spawn = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0);
        var quaternion = Quaternion.Euler(0, 0, Random.Range(0.0f, 360.0f));



        if (spawnTimer >= Random.Range(1f,5f))
        {
            Instantiate(Plane, spawn, quaternion);
            spawnTimer = 0f;
        }

    }
}
