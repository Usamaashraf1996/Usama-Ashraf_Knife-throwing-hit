using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public float speed = 30;
   
    public bool hit;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      //transform.Translate(Vector3.forward * speed * Time.deltaTime);if we want kinematic any thing so we can use physics formula force
        if (Input.GetKey(KeyCode.Space))
        {
          PlayerRb.AddForce(Vector3.forward * speed, ForceMode.Impulse);//physisc move formula

        }
            
       
        
    }
}

