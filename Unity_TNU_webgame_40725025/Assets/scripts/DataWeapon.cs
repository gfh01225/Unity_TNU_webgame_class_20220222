using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    [CreateAssetMenu(menuName = "g/Data Weapon",fileName ="data weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("飛行速度"), Range(0, 3500)]
        public float flyspeed = 500;
        [Header("攻擊力"), Range(0, 1000)]
        public float attack = 10;
        [Header("起始數量"), Range(1, 5)]
        public float countstart = 1;
        [Header("數量上限"), Range(1, 50)]
        public float countmax = 20;
        [Header("攻擊間隔"), Range(0, 5)]
        public float interval = 3.5f;

        [Header("生成位置")]
        public Vector3[] v3spawnpoint;
        [Header("武器物件")]
        public GameObject goweapon;


    }

}
