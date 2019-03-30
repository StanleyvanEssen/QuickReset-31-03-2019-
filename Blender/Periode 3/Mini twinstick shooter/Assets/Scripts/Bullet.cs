using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Vector3 m;

	void Update ()
    {
        transform.Translate(m * Time.deltaTime);
    }

    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Sample Text")
        {
            c.gameObject.GetComponent<MobHealth>().LoseHP(1);
            Destroy(gameObject);
        }
    }
}
