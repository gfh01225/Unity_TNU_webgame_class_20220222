using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    public class Weapon : MonoBehaviour
    {
        public float attack;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.tag == "enemy")
            {
                collision.gameObject.GetComponent<HurtSystem>().gethurt(attack);

                Destroy(gameObject);
            }

        }
    }
}

