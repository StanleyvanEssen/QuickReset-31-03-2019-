using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmManager : MonoBehaviour
{
    List<Alarm> A = new List<Alarm>();

    void Start ()
    {
        A.Add(new Alarm1());
        StartCoroutine(A[0].Time());
    }
	
	void Update ()
    {
		
	}
}
