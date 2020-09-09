using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (other.CompareTag("Shell"))
        {
            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}