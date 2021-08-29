using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flying : MonoBehaviour
{
    public float speed;
    public float boost;
    public Terrain terrain;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Fly script added to: " + gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
        if (Input.GetButton("Fire1"))
            transform.position += transform.forward * Time.deltaTime * boost;

        transform.Rotate(Input.GetAxis("Vertical"), 0.0f, -Input.GetAxis("Horizontal"));
    }
}
