using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting2 : MonoBehaviour
{
    //GameObject型を変数bulletで宣言します。
    public GameObject bullet;
    //Rigidbody型を変数rbで宣言します。
    Rigidbody rb;
    //float型を変数thrustで宣言して100の値を入れます。
    public float thrust = 100f;


    void Update()
    {
        //もしマウスボタンの左クリックが押されたら。
        if (Input.GetMouseButtonDown(0))
        {
            //GetComponentでRigidbodyを取得して弾をcloneで生成します。
            rb = Instantiate(bullet, transform.position, transform.rotation).GetComponent<Rigidbody>();
            //前方向にthrustの数字の分一度だけ力を加えます。
            rb.AddForce(transform.forward * thrust, ForceMode.Impulse);

            //３秒後に削除されます。
            Destroy(gameObject, 3f);

        }
    }
}