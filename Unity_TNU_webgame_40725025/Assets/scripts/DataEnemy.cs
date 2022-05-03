using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    [CreateAssetMenu(menuName = "g/Data Enemy", fileName = "data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("移動速度"), Range(0, 3500)]
        public float speed = 30;
        [Header("攻擊力"), Range(0, 500)]
        public float attack = 10;
        [Header("攻擊冷卻"), Range(0, 5)]
        public float cd = 1;
        [Header("血量"), Range(1, 5000)]
        public float hp = 100;
        [Header("經驗掉落機率"), Range(0, 200)]
        public float expDropProbability = 100;
        [Header("經驗掉落類型")]
        public TypeExp typeExp;
        [Header("走動停止距離"), Range(0, 30)]
        public float stopdis;

        public enum TypeExp
        {
            small ,middle ,large
        }

    }

}