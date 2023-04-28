using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Duck : Animal
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
        screenText.text = "Waddle waddle, i am a Duck!";
    }
}
