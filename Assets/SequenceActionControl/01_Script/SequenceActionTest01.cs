using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtil
{
    public class SequenceActionTest01 : SequenceActionBase
    {
        public SequenceActionTest01()
        {
            _coroutineFunc = Test01Coroutine();
        }


        public IEnumerator Test01Coroutine()
        {
            int countTime = 5;

            Debug.Log("start Test01Coroutine");

            while(countTime >= 0)
            {
                Debug.Log(string.Format("countTime : {0}", countTime));
                yield return new WaitForSeconds(1f);
                --countTime;
            }

            Debug.Log("end Test01Coroutine");

            yield break;
        }
    }
}
