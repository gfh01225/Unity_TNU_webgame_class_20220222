using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    /// <summary>
    /// 武器系統
    /// 儲存玩家擁有的武器資料
    /// 根據資料生成武器
    /// 賦予武器相關資料、飛行速度、攻擊
    /// </summary>
    public class weaponSystem : MonoBehaviour
    {
        [SerializeField, Header("武器資料")]
        private DataWeapon dataweapon;

        private float timer;

        /// <summary>
        /// 繪製圖示
        /// 編輯器內提示用
        /// </summary>
        private void OnDrawGizmos()
        {
            //顏色
            Gizmos.color = new Color(1, 0, 0, 0.3f);
            //圖示
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
        /// 每隔一段時間生成武器
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

