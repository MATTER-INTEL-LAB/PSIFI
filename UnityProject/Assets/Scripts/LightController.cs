using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light[] lights;
    private char sp = ')';

    private void Update()
    {
        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "sad")
            lights[0].enabled = false;
        else
            lights[0].enabled = true;
    }
}
