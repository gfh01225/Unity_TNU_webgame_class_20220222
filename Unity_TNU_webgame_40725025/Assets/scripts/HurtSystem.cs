using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace g
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("¦å¶q"), Range(0, 1000)]
        protected float hp;
        
        public void gethurt(float dmg)
        {
            hp -= dmg;
            if (hp <= 0) dead();
        }

        private void dead()
        {
            hp = 0;
        }
    }

}

