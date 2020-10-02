using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatySignHover : MonoBehaviour
{

    [SerializeField] float speed = 0.1f;
    [SerializeField] float amplitude = 1f;
    Vector3 anchor;
    
    // Start is called before the first frame update
    void Start()
    {
        anchor = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = anchor + Vector3.up * Mathf.Sin(Time.time * speed) * amplitude;
    }
}
