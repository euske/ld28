﻿// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	void Start () {
	}

    void OnCollisionEnter2D(Collision2D coll) {
        switch (coll.gameObject.tag) {
        case "Floor":
            audio.Play();
            break;

        case "Enemy":
            // Hit an enemy.
            GlobalScript.Instance.PlayerDied();
            break;
        }
    }

    void OnTriggerEnter2D(Collider2D coll) {
        switch (coll.gameObject.tag) {
        case "Goal":
            // Reached the goal.
            GlobalScript.Instance.PlayerReachedGoal();
            break;
        }
    }

    void OnTriggerExit2D(Collider2D coll) {
        switch (coll.gameObject.tag) {
        case "SafeZone":
            // Go outside the safe zone.
            GlobalScript.Instance.PlayerDied();
            break;
        }
    }

    // canJump: true if it can jump (landed).
    public bool canJump {
        get { return true; }
    }
}
