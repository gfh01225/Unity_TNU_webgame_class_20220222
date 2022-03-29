using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace G
{
    /// <summary>
    /// 上下角色控制
    /// 移動、動畫
    /// 
    /// </summary>

    public class TopDowncontroller : MonoBehaviour
    {
        #region 資料:速度 名稱 元件等
        [SerializeField,Header("移動速度"),Range(0,100)]
        private float moveSpeed; //移動速度
        private string parameterrun = "開關跑步";
        private string parameterdead = "開關死亡";
        private Animator player_ani; //動畫控制器
        private Rigidbody2D rig;//剛體
        private float h;
        private float v;


        #endregion

        #region 事件:程式入口(unity)
        private void Start()
        {
            player_ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            //MoveNAnimation();
            getinput();
            move();
        }
        #endregion

        #region 方法:較複雜行為
        private void getinput()
        {
            h = Input.GetAxis("Horizontal");
            v = Input.GetAxis("Vertical");

            //print(h);
        }

        private void move()
        {
            rig.velocity = new Vector2(h, v)*moveSpeed ;
            if (h != 0 || v != 0)
            {
                player_ani.SetBool("is_walking", true);
            }
            else
            {
                player_ani.SetBool("is_walking", false);
            }

            if (h < 0)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else if (h > 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
            //也可以是transform.eulerAngles = new Vector3(0, h > 0 ? 0 : 180, 0);

        }

        /*
        void MoveNAnimation()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");
            transform.Translate(new Vector3(Mathf.Abs(horizontalInput) , verticalInput, 0) * moveSpeed * Time.deltaTime);
            if (horizontalInput != 0 || verticalInput != 0)
            {
                player_ani.SetBool("is_walking", true);
            }
            else
            {
                player_ani.SetBool("is_walking", false);
            }
            if (horizontalInput < 0)
            {
                transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            }
            else if (horizontalInput > 0)
            {
                transform.rotation = Quaternion.Euler(0f, 0f, 0f);
            }
        }
        */
        #endregion

    }

}

