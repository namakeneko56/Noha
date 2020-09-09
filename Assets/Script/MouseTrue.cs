using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カーソル表示・非表示
        Cursor.visible = true;

        //カーソルのロック解除
        Cursor.lockState = CursorLockMode.None;
    }
}
