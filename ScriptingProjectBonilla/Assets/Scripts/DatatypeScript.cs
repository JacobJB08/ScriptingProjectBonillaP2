using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatatypeScript : MonoBehaviour
{
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        //dont do nothjing to physical position
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0); 

        //does change position
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.position += new Vector3(speed * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.A))
            transform.position += new Vector3(-speed * Time.deltaTime, 0.0f, 0.0f);

        if (Input.GetKey(KeyCode.W))
            transform.position += new Vector3(0.0f, 0.0f, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.position += new Vector3(0.0f, 0.0f, -speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

        if (Input.GetKey(KeyCode.Q))
            transform.position += new Vector3(0.0f, -speed * Time.deltaTime, 0.0f);
    }
}
