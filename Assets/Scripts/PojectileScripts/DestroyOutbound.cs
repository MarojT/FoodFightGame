using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DestroyOutbound : MonoBehaviour
{
    public float outBound = 50f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > outBound){
            Destroy(gameObject);
        }
    }
}
