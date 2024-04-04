using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyOutbound : MonoBehaviour
{
    public float upperBound = 50f;
    public float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > upperBound){
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound){
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
