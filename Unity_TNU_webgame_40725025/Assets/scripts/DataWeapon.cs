using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    [CreateAssetMenu(menuName = "g/Data Weapon",fileName ="data weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 3500)]
        public float flyspeed = 500;
        [Header("�����O"), Range(0, 1000)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 5)]
        public float countstart = 1;
        [Header("�ƶq�W��"), Range(1, 50)]
        public float countmax = 20;
        [Header("�������j"), Range(0, 5)]
        public float interval = 3.5f;

        [Header("�ͦ���m")]
        public Vector3[] v3spawnpoint;
        [Header("�Z������")]
        public GameObject goweapon;


    }

}
