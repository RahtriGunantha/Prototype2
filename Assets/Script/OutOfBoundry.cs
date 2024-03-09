using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundry : MonoBehaviour
{
    private float topScene = 30f;
    private float lowerScene = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topScene)
        {
            Destroy(gameObject);

        }
        else if(transform.position.z < lowerScene) 
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
