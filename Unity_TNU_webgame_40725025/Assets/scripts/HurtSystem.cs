using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace g
{
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("血量"), Range(0, 1000)]
        protected float hp;
        
        public virtual void gethurt(float dmg)
        {
            if(hp<=0)return;

            hp -= dmg;
            if (hp <= 0) dead();
        }

        protected virtual void dead()
        {
            hp = 0;
        }
    }

}

