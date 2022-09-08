using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float inputHorizontal;
    public float xRange = 10;
    public float speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xRange) { 
          transform.position=new Vector3(xRange,0,0);
        }
        if (transform.position.x <-xRange) { 
        transform.position=new Vector3(-xRange,0,0);
        }
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * inputHorizontal * speed * Time.deltaTime);
    }
}
