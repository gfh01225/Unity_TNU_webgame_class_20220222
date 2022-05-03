using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    public class EnemySystem : MonoBehaviour
    {
        [SerializeField, Header("敵人資料")]
        private DataEnemy data;
        [SerializeField, Header("玩家物件名稱")]
        private string namePlayer = "player";
        [SerializeField, Header("動畫攻擊參數")]
        private string parameterAttack = "attack";


        private Transform traPlayer;

        private float attacktimer;

        private Animator ani;
        private void Awake()
        {
            traPlayer = GameObject.Find(namePlayer).transform;
            ani = GetComponent<Animator>();
            
            
        }

        private void Update()
        {
            MoveToPlayer();





        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0.5f, 0, 0.6f);
            Gizmos.DrawSphere(transform.position, data.stopdis);
        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            float dis = Vector3.Distance(posEnemy, posPlayer);
            if (dis < data.stopdis)
            {
                attack();
            }
            else
            {
                transform.position = Vector3.Lerp(posEnemy, posPlayer, 0.5f * data.speed * Time.deltaTime);

                float y = posEnemy.x > posPlayer.x ? 180 : 0;
                transform.eulerAngles = new Vector3(0, y, 0);

            }

            
        }

        private void attack()
        {
            if(attacktimer < data.cd)
            {
                attacktimer += Time.deltaTime;
            }
            else
            {
                ani.SetTrigger(parameterAttack);
                attacktimer = 0;
            }
        }



    }



}

