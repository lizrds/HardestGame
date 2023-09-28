using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCollisions : MonoBehaviour
{

    public Vector3 speedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += speedEnemy * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        speedEnemy = -speedEnemy;
    }
}
