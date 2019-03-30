using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{

	void Start ()
    {
		
	}

    public IEnumerator Time()
    {
        yield return new WaitForSeconds(5);
        DoSpecial();
	}

    public virtual void DoSpecial()
    {

    }
}
