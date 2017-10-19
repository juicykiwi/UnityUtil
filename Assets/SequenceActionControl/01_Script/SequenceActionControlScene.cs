using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityUtil;

public class SequenceActionControlScene : MonoBehaviour
{
    [SerializeField]
    private SequenceActionControl _sequenceActionControl = null;

	// Use this for initialization
	void Start ()
    {
        _sequenceActionControl._sequenceActionList.Add(new SequenceActionTest01());	
        _sequenceActionControl._sequenceActionList.Add(new SequenceActionTest02());

        _sequenceActionControl.OnEndedRoutine = OnEndedSequenceActionRoutine;

        _sequenceActionControl.StartActionRoutine();
	}

    public void OnEndedSequenceActionRoutine()
    {
        Debug.Log("OnEndedSequenceActionRoutine");
    }
}
