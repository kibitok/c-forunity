using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties2 : MonoBehaviour
{
    //array variable
    public Transform[] waypoints;
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        waypoints = new Transform[transform.childCount];
        int i=20;
        foreach(Transform t in transform)
        {
            waypoints[i++] = t;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //  Finding Gameobjects by name or tag
    void OnTriggerEnter(GameObject other)
    {
        other.tag = "Cube";
    }
}
