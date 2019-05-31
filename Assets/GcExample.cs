using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GcExample : MonoBehaviour
{
    public int[] myArray;
    public float[] myfloatArray;
    public GameObject myObject;
    public float xPosition = 3f;
    public float yPosition = 3f;
    public float zPosition = 3f;
    public int lengthi=10;
    public int lengthj = 10;
    public int nelements=100;

    public Text scoreBoard;
    public int Score = 50;
    public int oldScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(ConcatExample(myArray));
        //  ObjectTest();

       Debug.Log( RandomList(nelements)); 

    }
   string ConcatExample(int [] intArray)
    {
        string line = intArray[0].ToString();
        // iteration
        for (int i =1; i < intArray.Length; i++)
        {
            line += "," + intArray[i].ToString();
        }
        return line;
    }
    void ObjectTest()
    {
        // iterate
        for (int i = 0; i < lengthi; i++)
        {
            for (int j = 0; j<lengthj; j++)
            {
                Instantiate(myObject, new Vector3(xPosition,yPosition,zPosition), Quaternion.identity);
            }
        }
    }
  void InputResource()
    {
        if (Input.GetKey(KeyCode.Space) && Score != oldScore)
        {
            Score += 10;

        }
        string scoreText = "score:" + Score.ToString();
        scoreBoard.text = scoreText;
        oldScore = Score;
    }
    // function that returns an aray value
    float [] RandomList(int numElements)
    {
        var result = new float[numElements];
        //looping
        for (int i = 0; i<numElements; i++)
        {
            result[i] = Random.value;
        }
        return result;
    }
}
