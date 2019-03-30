using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public int hp;
    public Vector3 v;
    public Vector3 x;
    public float hor;
    public float ver;
    public float speed;
    public Transform boyo;
    public GameObject bullet;
    public GameObject barrel;

    void Start ()
    {
		
	}

    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");
        v.x = hor;
        v.z = ver;
        transform.Translate(v * speed * Time.deltaTime);

        if (Input.GetButtonDown("up"))
        {
            boyo.rotation = Quaternion.Euler(0, 0, 0);
            Shoot();
        }
        if (Input.GetButtonDown("right"))
        {
            boyo.rotation = Quaternion.Euler(0, 90, 0);
            Shoot();
        }
        if (Input.GetButtonDown("down"))
        {
            boyo.rotation = Quaternion.Euler(0, 180, 0);
            Shoot();
        }
        if (Input.GetButtonDown("left"))
        {
            boyo.rotation = Quaternion.Euler(0, 270, 0);
            Shoot();
        }
    }

    public void LoseHP(int dmg)
    {
        hp -= dmg;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void Shoot()
    {
        GameObject G = Instantiate(bullet, barrel.transform.position, barrel.transform.rotation);
        Destroy(G, 5);
    }
}