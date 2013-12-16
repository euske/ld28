﻿// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class AlertOverlayScript : MonoBehaviour {
	
    // Text.
    public System.String text;

    // Text style.
    public GUIStyle textStyle = new GUIStyle();

    // Blinking duration.
    public float blinkingDuration = 0.2f;
    // Maximum blink count.
    public int maxBlinkCount = 20;

    private bool _blinking = true;
    private float _t0;

	void Start () {
        _t0 = Time.time;
	}

    void Update() {
        // Stop blinking if any key is pressed.
        bool button = (Input.GetButton("Horizontal") ||
                       Input.GetButton("Vertical") ||
                       Input.GetButton("Fire1") ||
                       Input.GetButton("Jump"));
        if (button) {
            _blinking = false;
        }
    }

    void OnGUI() {
        if (text != null && _blinking) {
            int count = (int)((Time.time-_t0) / blinkingDuration);
            if ((count % 2) == 0 && count < maxBlinkCount) {
                Rect r = getCenterRect(0.5f, 0.5f, 0.3f, 0.1f);
                GUI.Label(r, text, textStyle);
            }
        }
    }

    // getCenterRect(x, y, w, h):
    Rect getCenterRect(float x, float y, float w, float h)
    {
        return new Rect(Screen.width*(x-w/2), Screen.height*(y-h/2), 
                        Screen.width*w, Screen.height*h);
    }
}
