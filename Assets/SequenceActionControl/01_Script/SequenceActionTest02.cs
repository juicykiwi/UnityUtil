using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtil
{
    public class SequenceActionTest02 : SequenceActionBase
    {
        public SequenceActionTest02()
        {
            _coroutineFunc = Test02Coroutine();
        }


        public IEnumerator Test02Coroutine()
        {
            int countTime = 5;

            Debug.Log("start Test02Coroutine");

            while(countTime >= 0)
            {
                Debug.Log(string.Format("countTime : {0}", countTime));
                yield return new WaitForSeconds(1f);
                --countTime;
            }

            Debug.Log("end Test02Coroutine");

            yield break;
        }
    }
}
