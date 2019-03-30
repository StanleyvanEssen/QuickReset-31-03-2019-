using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHealth : MobMovement
{
    public int hp;

    void Start ()
    {
		
	}

	void Update ()
    {
		
	}

    public virtual void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
