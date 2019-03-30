using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueQ : MonoBehaviour
{
    public Text girlo1;
    public Text girlo2;
    public Text digitalboio;
    public string startComputer;
    public string[] man;
    public string[] computer;
    int i1;
    int i2;

    void Start()
    {
        digitalboio.text = startComputer;
        i1 += 0;
        i2 += 1;
        girlo1.text = man[i1];
        girlo2.text = man[i2];
    }

    public void Option1()
    {
        girlo1.text = man[i1];
        i1 += 0;
        if (i1 == 0)
        {
            i1 += 3;
            girlo1.text = man[i1];
            i1 += 1;
            girlo2.text = man[i1];
        }
    }

    public void Option2()
    {
        girlo2.text = man[i2];
        i2 += 0;
        if (i2 == 1)
        {
            i2 += 5;
            girlo1.text = man[i2];
            i2 += 1;
            girlo2.text = man[i2];
        }
    }
}
