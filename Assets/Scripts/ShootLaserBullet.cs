﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaserBullet : MonoBehaviour
{
    public float speed;
    public GameObject laserPrefab;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(laserPrefab, transform.position, laserPrefab.transform.rotation);
            laserPrefab.GetComponent<LaserBullet>();
        }
    }
}
