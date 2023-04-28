using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

public MainManager mainManager;

void Awake()
{
    mainManager = GameObject.Find("Main Manager").GetComponent<MainManager>();
    mainManager.SpawnCat();
    mainManager.SpawnDuck();
}

}
