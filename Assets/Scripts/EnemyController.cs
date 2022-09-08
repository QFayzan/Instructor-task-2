using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 2f;           //Enemy movespeed is negative since they are "falling down"
    private float lowerBound = -10;    //-10 of z is out of screen area and is convenient time to destroy gameobjects

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.back * Time.deltaTime * speed); // make game object move continously
        //Logic to destroy enemies when out of screen to save resources
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);

        }
    }
}

