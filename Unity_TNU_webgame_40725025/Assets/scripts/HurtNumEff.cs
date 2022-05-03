using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace g
{
    public class HurtNumEff : MonoBehaviour
    {
        private CanvasGroup group;

        private void Start()
        {
            StartCoroutine(test());
        }

        private IEnumerator test()
        {
            print("rrrrrrrrrrrrrrrr");
            yield return new WaitForSeconds(1);

            print("À°§Ú¶}ª½¼½");
        }
    }
}


