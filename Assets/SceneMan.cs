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
        if (Input.GetKey("up"))
        {
            SceneManager.LoadScene(sceneBuildIndex:0); //webcam
        }

        if (Input.GetKey("down"))
        {
            SceneManager.LoadScene(sceneBuildIndex:1); //mario
        }

        //if (Input.GetKey("left"))
        //{
        //    SceneManager.LoadScene(sceneBuildIndex:2);
        //}
    }

}
