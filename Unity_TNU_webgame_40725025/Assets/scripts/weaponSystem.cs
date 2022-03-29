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
                Instantiate(dataweapon.goweapon);
                timer = 0;
            }
            else
            {
                timer += Time.deltaTime;
            }
        }
    }


}

