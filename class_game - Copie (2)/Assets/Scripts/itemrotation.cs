using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRotation : MonoBehaviour
{

    public int RotationSpeed = 100;
    private Transform ItemTransform;

    // Start is called before the first frame update
    void Start()
    {
        ItemTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ItemTransform.Rotate(RotationSpeed * Time.deltaTime, RotationSpeed * Time.deltaTime, RotationSpeed * Time.deltaTime);
    }
}
/* Vector3 Origin = new Vector(1f, 1f, 1f);
 * Vector3 ForWardDirection = Vector3.forward;
 * donn�es de rotation gyroscopiques 
 */
