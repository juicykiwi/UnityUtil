using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityUtil
{
    public class SequenceActionBase
    {
        protected string _coroutineName = "";
        public string CoroutineName { get { return _coroutineName; } }

        protected IEnumerator _coroutineFunc = null;
        public IEnumerator CoroutineFunc { get { return _coroutineFunc; } }
    }
}