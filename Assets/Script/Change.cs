using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Invoke("ChangeScene", 6.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeScene()
    {
        SceneManager.LoadScene("Title");
    }
}