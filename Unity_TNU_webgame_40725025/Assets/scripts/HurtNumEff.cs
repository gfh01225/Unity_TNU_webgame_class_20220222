using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace g
{
    public class HurtNumEff : MonoBehaviour
    {
        [SerializeField, Header("淡入出每次值"), Range(0, 0.3f)]
        private float valueFade = 0.1f;
        [SerializeField, Header("放大小每次值"), Range(0, 0.1f)]
        private float valueScale = 0.001f;
        [SerializeField, Header("位移每次值"), Range(0, 10)]
        private float valueOffset = 0.1f;

        private CanvasGroup group;
        private RectTransform rect;
        private Text textdmg;

        private void Awake() 
        {
            textdmg = transform.Find("dmg").GetComponent<Text>();
            
        }

        private void Start()
        {
            //StartCoroutine(test());
            group = GetComponent<CanvasGroup>();
            rect = GetComponent<RectTransform>();

            
            
            //GetComponent<Rigidbody2D>().AddForce(new Vector3() * dataweapon.flyspeed);

            StartCoroutine(fade());
            StartCoroutine(scale());
            StartCoroutine(offset());

            StartCoroutine(fade(-1,1f));
            StartCoroutine(scale(-1,1f));
            //StartCoroutine(offset(-1,1f));

            Destroy(this.gameObject,3f);
            
        }

        public void updatedmg(float getdmg)
        {
            textdmg.text = getdmg.ToString();

        }

        private IEnumerator test()
        {
            print("rrrrrrrrrrrrrrrr");
            yield return new WaitForSeconds(1);

            print("À°§Ú¶}ª½¼½");
        }
        private IEnumerator fade(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for(int i = 0;i<10;i++)
            {
                group.alpha+= valueFade * add;
                yield return new WaitForSeconds(0.02f);

            }
        }

        private IEnumerator scale(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);

            for(int i = 0;i<5;i++)
            {
                rect.localScale += new Vector3(valueScale,valueScale,0) * add;
                yield return new WaitForSeconds(0.02f);

            }
        }

        private IEnumerator offset(float add = 1, float wait = 0)
        {
            yield return new WaitForSeconds(wait);
            for(int i = 0;i<10;i++)
            {
                rect.anchoredPosition += Vector2.up * valueOffset * add;
                yield return new WaitForSeconds(0.02f);

            }
        }

    }
}


