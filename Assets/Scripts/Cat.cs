using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        DisplayText();
    }


    public override void DisplayText()
    {
        screenText.text = "Meow, I am a cat! :3";
    }
}
