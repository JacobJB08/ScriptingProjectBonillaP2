using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiat : MonoBehaviour
{
    public Rigidbody rocketPrefab;
    public Transform barrelEnd;
    public float power = 500.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody rocketInstance;
            rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            rocketInstance.AddForce(barrelEnd.forward * power);
        }
    }
}
