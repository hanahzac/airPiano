using System;
using System.Collections;
using System.Collections.Generic;
using UltrahapticsCoreAsset;
using UnityEngine;

public class TrackOculusHandsMapToLeapMotion : MonoBehaviour
{
    //private Array fingerTips;
    private Transform left_index_trans;

    [Header("Link to the sensation source")]
    public GameObject sensationSource;

    void Start()
    {
        /*
        fingerTips = GameObject.FindGameObjectsWithTag("Finger_Tips");
        foreach (GameObject fingertip in fingerTips) {
            Debug.Log("Found fingertip " + fingertip.name + " at pos: "+fingertip.transform.position);
        }
        */
    }

    void Update()
    {
        // track the transform for the left index finger tip
        left_index_trans = GameObject.Find("l_index_finger_tip_marker").transform;
        sensationSource.transform.position = left_index_trans.position;
        Debug.Log("Moving sensation spot to "+left_index_trans.position);
    }
}
