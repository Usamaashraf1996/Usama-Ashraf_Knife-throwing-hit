using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Rigidbody PlayerRb;
    public bool hit;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if (collision.gameObject.CompareTag("Log"))
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = true;//agr comparetag sy collied kry tu iskinematic hujay 
            Debug.Log("ok");
        }
        if (collision.gameObject.CompareTag("Log")) { 
        this.transform.SetParent(collision.collider.transform);//is comparetag sy collied hu tu usi ka parent bn jay
        }
    }

}
