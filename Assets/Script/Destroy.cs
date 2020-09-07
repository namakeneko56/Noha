using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //当たり判定メソッド
    private void OnCollisionEnter(Collision collision)
    {
        //衝突したオブジェクトがBullet(大砲の弾)だったとき
        if (collision.gameObject.CompareTag("Shell"))
        {
            //敵(スクリプトがアタッチされているオブジェクト自身)を削除
            Destroy(gameObject);
            //弾(引数オブジェクト)を削除
            Destroy(collision.gameObject);
        }
    }

}