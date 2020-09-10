using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{

    //SE用変数
    public AudioClip sound1;
    AudioSource audioSource1;

    void Start()
    {
        //Componentを取得
        audioSource1 = GetComponent<AudioSource>();
    }

    
    void OnTriggerEnter(Collider other)
    {

        //ぶつかったオブジェクトのTagにShellという名前が書いてあったならば（条件）.
        if (other.CompareTag("Shell"))
        {
            //音(sound1)を鳴らす
            AudioSource.PlayClipAtPoint(sound1, transform.position);

            //ぶつかってきたオブジェクトを破壊する.
            Destroy(other.gameObject);
            //自身も削除
            Destroy(gameObject);
            
        }
    }


}