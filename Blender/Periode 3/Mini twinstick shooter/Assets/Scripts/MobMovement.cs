using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobMovement : MonoBehaviour
{
    public float speed;
    public GameObject player;

    void Start()
    {

    }

    void Update()
    {

    }

    public virtual void Movement()
    {
        transform.LookAt(player.transform);
        transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }
}
