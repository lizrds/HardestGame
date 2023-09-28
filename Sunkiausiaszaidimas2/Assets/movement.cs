using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKey(KeyCode.W) )
        {
            transform.position += new Vector3(0, 0, 0.025f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.025f);
        }

        transform.position += moveDirection * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("enemy"))
        {
            transform.position = new Vector3(-12, 0, -3);
        }
    }
}
