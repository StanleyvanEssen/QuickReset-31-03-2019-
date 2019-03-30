using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public Vector3 m;

    void Update()
    {
        transform.Translate(m * Time.deltaTime);
    }

    void OnTriggerEnter(Collider c)
    {
        c.gameObject.GetComponent<Player>().LoseHP(1);
        Destroy(gameObject);
    }
}
