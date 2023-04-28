using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : Animal
{
    public MainManager mainManager;
    // Start is called before the first frame update
    void Start()
    {
        mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
        screenText = GameObject.Find("Text").GetComponent<Text>();
        DisplayText();
    }


    public override void DisplayText()
    {  
        screenText.text = "Meow, I am a cat! :3";
    }
}
