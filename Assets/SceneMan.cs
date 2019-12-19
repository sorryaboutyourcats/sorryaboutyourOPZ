using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMan : MonoBehaviour
{
    void Awake()
    {
        int numSceneMan = FindObjectsOfType<SceneMan>().Length;
        if (numSceneMan > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    //void Start()
    //{
    //    SceneManager.LoadScene(sceneBuildIndex:0);
    //}

    void Update()
    {
        if (Input.GetKey("1"))
        {
            SceneManager.LoadScene(sceneBuildIndex:0); //mario
        }

        if (Input.GetKey("2"))
        {
            SceneManager.LoadScene(sceneBuildIndex:1); //webcam
        }

        if (Input.GetKey("3"))
        {
            SceneManager.LoadScene(sceneBuildIndex:2); //line8
        }
        if (Input.GetKey("q")) //quit
        {
            Application.Quit();
        }
    }

}
