using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDamage : MobHealth
{

	void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    public virtual void OnCollisionEnter(Collision c)
    {
        c.gameObject.GetComponent<Player>().LoseHP(1);
    }
}
