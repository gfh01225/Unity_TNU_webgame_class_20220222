using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    /// <summary>
    /// �Z���t��
    /// �x�s���a�֦����Z�����
    /// �ھڸ�ƥͦ��Z��
    /// �ᤩ�Z��������ơB����t�סB����
    /// </summary>
    public class weaponSystem : MonoBehaviour
    {
        [SerializeField, Header("�Z�����")]
        private DataWeapon dataweapon;

        [SerializeField, Header("�Z���R���ɶ�"), Range(0, 5)]
        private float destorytime = 3.5f;

        private float timer;

        /// <summary>
        /// ø�s�ϥ�
        /// �s�边�����ܥ�
        /// </summary>
        private void OnDrawGizmos()
        {
            //�C��
            Gizmos.color = new Color(1, 0, 0, 0.3f);
            //�ϥ�
            for (int i = 0; i <dataweapon.v3spawnpoint.Length;i++)
            {
                Gizmos.DrawSphere(transform.position + dataweapon.v3spawnpoint[i], 0.3f);
            }

            for (int i = 0; i < dataweapon.v3dir.Length; i++)
            {
                Gizmos.DrawSphere(transform.position + dataweapon.v3dir[i], 0.3f);
            }

        }

        private void Start()
        {
            //Physics2D.IgnoreLayerCollision(6, 7);
            //Physics2D.IgnoreLayerCollision(7, 7);
        }

        private void Update()
        {
            spawnweapon();
        }

        /// <summary>
        /// �C�j�@�q�ɶ��ͦ��Z��
        /// </summary>
        private void spawnweapon()
        {           
            if(timer >= dataweapon.interval)
            {
                Vector3 pos = transform.position + dataweapon.v3spawnpoint[Random.Range(0,dataweapon.v3spawnpoint.Length)];

                GameObject temp =  Instantiate(dataweapon.goweapon,pos,Quaternion.identity);
                int dirrand = Random.Range(0, dataweapon.v3dir.Length);
                temp.GetComponent<Rigidbody2D>().AddForce(dataweapon.v3dir[dirrand] * dataweapon.flyspeed);

                float rotationZ = Mathf.Atan2(dataweapon.v3dir[dirrand].y, dataweapon.v3dir[dirrand].x) * Mathf.Rad2Deg;
                temp.transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ);
                Destroy(temp, destorytime);

                timer = 0;

                GetComponent<Animator>().SetTrigger("attack");
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }


}

