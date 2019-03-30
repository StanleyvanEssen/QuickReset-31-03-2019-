using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueT : MonoBehaviour
{
    public Text boio1;
    public Text boio2;
    public Text boio3;
    public Text digitalboio;
    public string startComputer;
    public string startMan1;
    public string startMan2;
    public string startMan3;
    [TextArea(1,7)]
    public string[] man;
    [TextArea(1,7)]
    public string[] computer;
    int i;
    int i2;

	void Start ()
    {
        digitalboio.text = startComputer;
        boio1.text = startMan1;
        boio2.text = startMan2;
        boio3.text = startMan3;
    }

    public void Option1()
    {
        if (i == 0)
        {
            i += 1;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 1;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the first button and then again the first button
        if (i == 3)
        {
            i += 7;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 4;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the second button and then the first button
        if (i == 6)
        {
            i += 13;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 6;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the third button and then the first button
        if (i == 9)
        {
            i += 19;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 8;
            digitalboio.text = computer[i2];
            return;
        }
    }

    public void Option2()
    {
        if (i == 0)
        {
            i += 4;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 2;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the first button and then the second button
        if (i == 3)
        {
            i += 10;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 5;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the second button and then again the second button
        if (i == 6)
        {
            i += 16;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 7;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the third button and then the second button
        if (i == 9)
        {
            i += 22;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 9;
            digitalboio.text = computer[i2];
            return;
        }
    }

    public void Option3()
    {
        if (i == 0)
        {
            i += 7;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 3;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the first button and then the third button
        if (i == 3)
        {
            i += 13;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 6;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the second button and then the third button
        if (i == 6)
        {
            i += 19;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 8;
            digitalboio.text = computer[i2];
            return;
        }
        //When you choose the third button and then again the third button
        if (i == 9)
        {
            i += 25;
            boio1.text = man[i];
            i += 1;
            boio2.text = man[i];
            i += 1;
            boio3.text = man[i];
            i2 += 10;
            digitalboio.text = computer[i2];
            return;
        }
    }
}