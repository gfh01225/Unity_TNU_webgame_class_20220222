using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    [CreateAssetMenu(menuName = "g/Data Enemy", fileName = "data Enemy")]
    public class DataEnemy : ScriptableObject
    {
        [Header("���ʳt��"), Range(0, 3500)]
        public float speed = 30;
        [Header("�����O"), Range(0, 500)]
        public float attack = 10;
        [Header("�����N�o"), Range(0, 5)]
        public float cd = 1;
        [Header("��q"), Range(1, 5000)]
        public float hp = 100;
        [Header("�g�籼�����v"), Range(0, 200)]
        public float expDropProbability = 100;
        [Header("�g�籼������")]
        public TypeExp typeExp;
        [Header("���ʰ���Z��"), Range(0, 30)]
        public float stopdis;

        public enum TypeExp
        {
            small ,middle ,large
        }

    }

}