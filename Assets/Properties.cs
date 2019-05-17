using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{

    public  float mymass = 10f;
    public float mydrag = 1.2f;
    public  float myforce = 10f;
    public float mymass2 = 10f;
    public GameObject mygameobject;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        Renderer rb = mygameobject.GetComponent<Renderer>();
        /*rb.mass = mymass;
        rb.drag = mydrag;
        rb.AddForce(Vector3.up * myforce);
        */
        rb.material.color = Color.blue;
        mybehaviour();
    }
    void mybehaviour()
    {
        Rigidbody rb2 = GetComponent<Rigidbody>();
        rb2.mass = mymass2;
    }
    // finding child game objects

}
