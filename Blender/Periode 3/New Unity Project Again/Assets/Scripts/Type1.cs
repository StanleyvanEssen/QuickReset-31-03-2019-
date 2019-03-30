using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type1 : Walker
{
    public Vector3 v;

    void Start()
    {

    }

    void Update()
    {
        Walk();
        DoSpecial();
    }

    public override void DoSpecial()
    {
        transform.Rotate(v);
    }
}
