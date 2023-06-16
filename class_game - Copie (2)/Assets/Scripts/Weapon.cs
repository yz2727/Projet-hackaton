using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update

    public Camera playerCamera;
    public Transform shootPoint;
    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
            Debug.Log("Gotcha!");
        }
    }

    void Shoot()
    {
        Ray ray = playerCamera.ViewportPointToRay(new Vector3 (0.5f,0.5f,0f));
        RaycastHit hit;
        Vector3 target;

        //pour tirer
        if(Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }else
        {
            target = ray.GetPoint(75);
        }
        
        //creation du projectile et de la direction
        Vector3 shootDirection = target-shootPoint.position;
        GameObject realBullet = Instantiate(bullet, shootPoint.position, Quaternion.identity);
        realBullet.transform.forward = shootDirection.normalized; //direction du bullet
        realBullet.GetComponent<Rigidbody>().AddForce(shootDirection.normalized*10, ForceMode.Impulse); //caracteristiques du bullet

    }
}