using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<bool> b = new List<bool>();

    private void Start()
    {
        for(int i = 0; i < b.Count; i++)
        {
            b[i] = !b[i];
        }
    }
}