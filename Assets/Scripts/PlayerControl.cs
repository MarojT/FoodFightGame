using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class playerControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float verticalInput;
    public float speed = 10f;
    public float xRange = 10;
    public float zRange = 10;
    public GameObject projectilePrefabs;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <-xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefabs, transform.position,  projectilePrefabs.transform.rotation);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
