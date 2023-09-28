using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(transform.rotation.x, transform.position.y, transform.position.z + speed);
    }
}
