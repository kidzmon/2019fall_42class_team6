﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class CanvasWithDevice : MonoBehaviour {
    private Canvas canvas;
    // List<InputDevice> inputDevices;

    void Start() {
        canvas = this.GetComponent<Canvas>();
        if(XRDevice.isPresent) {
            canvas.renderMode = RenderMode.WorldSpace;
            canvas.transform.position = new Vector3(2.0f, 1.5f, -0.3f);
            canvas.transform.localScale = new Vector3(0.004f, 0.004f, 0.004f);
        }
        else {
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            canvas.transform.position = new Vector3(0.0f, 0.0f, 100.0f);
        }
        // inputDevices = new List<InputDevice>();
        // InputDevices.GetDevices(inputDevices);
    }

    void Update() {
    }
}
