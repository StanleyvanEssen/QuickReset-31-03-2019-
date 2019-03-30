using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob1 : MobDamage
{
    public bool b;
    public GameObject barrel;
    public GameObject bullet;

	void Start ()
    {
		
	}
	
	void Update ()
    {
        Movement();
        LoseHP(0);
        if(b == true)
        {
            GameObject G = Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
            Destroy(G, 5);
        }
	}

    public override void OnCollisionEnter(Collision c)
    {
        base.OnCollisionEnter(c);
    }
}
