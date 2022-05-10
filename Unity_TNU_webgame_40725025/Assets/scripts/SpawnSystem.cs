using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    public class SpawnSystem : MonoBehaviour
    {
        [SerializeField,Header("生成敵人物件")]
        private GameObject goEnemy;
        [SerializeField,Header("敵人生成點")]
        private Transform[] traspawn;
        [SerializeField,Header("生成延遲"),Range(0,5)]
        private float delay = 1;
        [SerializeField,Header("生成間隔"),Range(0,5)]
        private float interval = 2.5f;


        private void Awake()
        {
            InvokeRepeating("spawn",delay,interval);
        }

        private void spawn()
        {
            int ran = Random.Range(0,traspawn.Length);
            Instantiate(goEnemy,traspawn[ran].position,Quaternion.identity);

        }
    
    }
}

