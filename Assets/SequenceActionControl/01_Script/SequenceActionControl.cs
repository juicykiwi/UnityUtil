using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtil
{
    public class SequenceActionControl : MonoBehaviour
    {
        public Action OnEndedRoutine = null;

        public List<SequenceActionBase> _sequenceActionList = new List<SequenceActionBase>();


        public void StartActionRoutine()
        {
            StartCoroutine(RunActionRoutine());
        }


        IEnumerator RunActionRoutine()
        {
            for (int index = 0; index < _sequenceActionList.Count; ++index)
            {
                if (null == _sequenceActionList[index])
                {
                    continue;
                }

                IEnumerator coroutineFunc = _sequenceActionList[index].CoroutineFunc;
                if (null == coroutineFunc)
                {
                    continue;
                }

                yield return StartCoroutine(coroutineFunc);
            }

            if (null != OnEndedRoutine)
            {
                OnEndedRoutine();
            }

            yield break;
        }
    }
}