using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walker : MonoBehaviour
{
    public float speed;

	void Start ()
    {
		
	}

    public void Walk()
    {
        transform.Translate(Vector3.forward * speed);
    }

    public virtual void DoSpecial()
    {

    }
}
