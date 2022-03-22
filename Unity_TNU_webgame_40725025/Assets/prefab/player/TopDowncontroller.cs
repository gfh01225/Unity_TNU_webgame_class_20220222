using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace G
{
    /// <summary>
    /// �W�U���ⱱ��
    /// ���ʡB�ʵe
    /// 
    /// </summary>

    public class TopDowncontroller : MonoBehaviour
    {
        #region ���:�t�� �W�� ����
        [SerializeField,Header("���ʳt��"),Range(0,100)]
        private float moveSpeed; //���ʳt��
        private string parameterrun = "�}���]�B";
        private string parameterdead = "�}�����`";
        private Animator player_ani; //�ʵe���
        private Rigidbody2D rig;//����
        private float h;
        private float v;


        #endregion

        #region �ƥ�:�{���J�f(unity)
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

        #region ��k:�������欰
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
            //�]�i�H�Otransform.eulerAngles = new Vector3(0, h > 0 ? 0 : 180, 0);

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

