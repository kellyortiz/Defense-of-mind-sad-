using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject bullet1Prefab;
    public GameObject bullet2Prefab;
    public GameObject bullet3Prefab;
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;
    public Transform firePointGeneric = null;

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Q) && (this.tag == "island1"))
        {
            this.firePointGeneric = firePoint;
       
        }
        if (Input.GetKeyUp(KeyCode.W) && (this.tag == "island2"))
        {
            this.firePointGeneric = firePoint2;

        }
        if (Input.GetKeyUp(KeyCode.E) && (this.tag == "island3"))
        {
            this.firePointGeneric = firePoint3;

        }
        if (Input.GetKeyUp(KeyCode.R) && (this.tag == "island4"))
        {
            this.firePointGeneric = firePoint4;

        }
        if (Input.GetKeyUp(KeyCode.T) && (this.tag == "island5"))
        {
            this.firePointGeneric = firePoint5;

        }

        if (firePointGeneric != null)
        {
            Instantiate(bulletPrefab, this.firePointGeneric.position, this.firePointGeneric.rotation);
            Instantiate(bullet1Prefab, this.firePointGeneric.position, this.firePointGeneric.rotation);
            Instantiate(bullet2Prefab, this.firePointGeneric.position, this.firePointGeneric.rotation);
            Instantiate(bullet3Prefab, this.firePointGeneric.position, this.firePointGeneric.rotation);

            firePointGeneric = null;
        }
    } 
    } 
