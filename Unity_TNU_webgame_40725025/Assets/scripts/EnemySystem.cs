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

        private Transform traPlayer;

        private void Awake()
        {
            traPlayer = GameObject.Find(namePlayer).transform;

            
            
        }

        private void Update()
        {
            MoveToPlayer();





        }

        private void MoveToPlayer()
        {
            Vector3 posEnemy = transform.position;
            Vector3 posPlayer = traPlayer.position;

            transform.position =  Vector3.Lerp(posEnemy,posPlayer, 0.5f*data.speed*Time.deltaTime);

            float y = posEnemy.x > posPlayer.x ? 180 : 0;
            transform.eulerAngles = new Vector3(0, y, 0);
        }



    }



}

