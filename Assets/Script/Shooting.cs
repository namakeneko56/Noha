using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float shotSpeed;
    public int shotCount = 1;
    int RevivaleFlame = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (shotCount > 0)
            {
                shotCount -= 1;

                GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position, Quaternion.Euler(transform.parent.eulerAngles.x, transform.parent.eulerAngles.y, 0));
                Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
                bulletRb.AddForce(transform.forward * shotSpeed);

                //射撃されてから3秒後に銃弾のオブジェクトを破壊する.

                Destroy(bullet, 3.0f);
            }
            

        }
        if (shotCount == 0)
        {


            RevivaleFlame++;
            if (RevivaleFlame == 60)
            {
                shotCount = 1;
                RevivaleFlame = 0;
            }
        }
        


    }
}