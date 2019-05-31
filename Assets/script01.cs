using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script01 : MonoBehaviour
{
    public Text myText;
    public Image myImage;

    [HideInInspector]
    public float timeScale;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeScale = Time.deltaTime;
        myText.text = timeScale.ToString();
    }
}
