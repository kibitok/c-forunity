using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propagation : MonoBehaviour
{
    public GameObject cube;
    public Transform cubePosition;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Awake()
    {
        int length = 1000;
        //iteration
        for (int i = 0; i > length; i++)
        {
            Instantiate(cube, new Vector3(i * 2.0f, 0, 0), Quaternion.identity);
        }
    }
}
