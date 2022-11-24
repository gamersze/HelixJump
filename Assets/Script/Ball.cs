using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
    public Vector3 startposition;
    public Levelpro levelpro;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        startposition = transform.position;
        
    }

    
    void Update()
    {
        transform.position = new Vector3(startposition.x, transform.position.y, startposition.z);

    }

    public void OnCollisionEnter(Collision collision)
    {
        
       if(collision.gameObject.tag == "platform")
        {
            ///rb.AddForce(Vector3.up * jumpForce);
            rb.velocity = new Vector3(0, jumpForce, 0); 
        }
        
        if(collision.gameObject.tag == "wrongarea")
        {
            Time.timeScale = 0f;

        }
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "destroyer" || other.gameObject.tag == "endline")
        {
            print("e");
            StartCoroutine(DestroyRing(other.transform.parent.gameObject));

            levelpro.FillBar();

          //  other.transform.parent.gameObject.GetComponent<MeshRenderer>().enabled = false;

        }
    }

    public IEnumerator DestroyRing(GameObject destroyObject)
    {
        print("a");
        yield return new WaitForSeconds(0.2f);
        Destroy(destroyObject);
    }
}
