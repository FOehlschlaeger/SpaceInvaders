using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersController : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float interval = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

    void SpawnMonster()
    {
        float v = Random.value;
        if (v < 0.2)
        {
            GameObject g = Instantiate(monster1, transform.position, Quaternion.identity);
        }
        else if (v < 0.4)
        {
            GameObject g = Instantiate(monster2, transform.position, Quaternion.identity);
        }
    }
}
