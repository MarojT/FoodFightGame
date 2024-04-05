using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class DestroyOutbound : MonoBehaviour
{
    public float upperBound = 50f;
    public float lowerBound = -10;
    public static Health pHealth = new Health();
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
            Debug.Log(pHealth.hPoint);
            pHealth.hPoint -=1;
            Debug.Log(pHealth.hPoint);
            Destroy(gameObject);
            if (pHealth.hPoint <= 0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("Game Over!");
            }
        }

    }
}
