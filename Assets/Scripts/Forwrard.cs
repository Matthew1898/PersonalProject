using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forwrard : MonoBehaviour
{
    public float speed =50.0f;
    public float forwardinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardinput = Input.GetAxis("Vertical");
        transform.position =(Vector3.forward * forwardinput * Time.deltaTime * speed);
    }
}
