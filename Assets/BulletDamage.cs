using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "enemyship"){
            Destroy(coll.gameObject);
        }

        Destroy(gameObject);
    }
}
