using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MainManager : MonoBehaviour
{
    public Button cButton;
    public Button dButton;
    public GameObject duckPrefab;
    public GameObject catPrefab;
    public bool startCat = false;
    public bool startDuck = false;

    void Awake()
    {   
        DontDestroyOnLoad(gameObject);
        cButton.onClick.AddListener(StartCat);
        dButton.onClick.AddListener(StartDuck);
    }

public void StartCat()
{
    SceneManager.LoadScene(1);
    startCat = true;
}

public void StartDuck()
{
    SceneManager.LoadScene(1);
    startDuck = true;
}

public void SpawnCat()
{
    Scene scene = SceneManager.GetActiveScene();
    if (scene.name == "Main" && startCat == true)
    {
        Instantiate(catPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

public void SpawnDuck()
{
    Scene scene = SceneManager.GetActiveScene();
    if (scene.name == "Main" && startDuck == true)
    {
        Instantiate(duckPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
}
