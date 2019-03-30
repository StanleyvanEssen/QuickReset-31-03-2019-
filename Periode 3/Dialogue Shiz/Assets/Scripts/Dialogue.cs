using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public string[] Questions;
    public string[] Answers;
    public bool[] InfoGiver;
    
	void Start ()
    {

    }

    void Update()
    {
        if (InfoGiver[0] == true)
        {
            Debug.Log(Answers[0]);
        }
        if (InfoGiver[1] == true)
        {
            Debug.Log(Answers[1]);
        }
        if (InfoGiver[2] == true)
        {
            Debug.Log(Answers[2]);
        }
        if (InfoGiver[3] == true)
        {
            Debug.Log(Answers[3]);
        }
        if (InfoGiver[4] == true)
        {
            Debug.Log(Answers[4]);
        }
        if (InfoGiver[5] == true)
        {
            Debug.Log(Answers[5]);
        }
    }
}