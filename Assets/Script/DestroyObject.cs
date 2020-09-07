using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    public int damage;          //当たった部位毎のダメージ量
    private GameObject enemy;   //敵オブジェクト
    

    void Start()
    {
        enemy = GameObject.Find("Enemy");   //敵情報を取得
    }

    void OnTriggerEnter(Collider other)
    {

        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (other.CompareTag("Shell"))
        {

            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
        }
    }
}