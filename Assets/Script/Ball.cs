using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;
   public Vector3 startposition;

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
        rb.AddForce(Vector3.up * jumpForce);

       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "destroyer")
        {
            print("e");
            StartCoroutine(DestroyRing(other.transform.parent.gameObject));

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
