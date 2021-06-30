using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{
    public GameObject bullet; 
    public float interval = 1;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }

    void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
