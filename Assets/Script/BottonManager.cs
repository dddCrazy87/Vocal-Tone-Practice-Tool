using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BottonManager : MonoBehaviour {
    [SerializeField] private Button StartRec, StopRec;
    
    private void Start() {
        StartRec.interactable = true;
        StopRec.interactable = false;
    }

    public void StartRecIsClick() {
        StartRec.interactable = false;
        StopRec.interactable = true;
    }

    public void StopRecIsClick() {
        StartRec.interactable = true;
        StopRec.interactable = false;
    }
}
