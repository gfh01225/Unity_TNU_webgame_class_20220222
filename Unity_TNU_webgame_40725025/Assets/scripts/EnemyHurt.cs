using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace g
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("畫布傷害數值")]
        private GameObject gocanvashurt;
        

        private string parameterdead = "dead";
        private Animator ani;

        private EnemySystem enemySystem;

        private void Awake()
        {
            ani = GetComponent<Animator>();
            enemySystem = GetComponent<EnemySystem>();
            hp = data.hp;
        }

        public override void gethurt(float dmg)
        {
            base.gethurt(dmg);

            GameObject temp =  Instantiate(gocanvashurt,transform.position,Quaternion.identity);
            temp.GetComponent<HurtNumEff>().updatedmg(dmg);

        }

        protected override void dead()
        {
            base.dead();
            ani.SetTrigger(parameterdead);

            enemySystem.enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject,1.5f);

        }
        

    }

}

