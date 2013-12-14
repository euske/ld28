﻿// -*- tab-width: 4 -*-
using UnityEngine;
using System.Collections;

public class GlobalScript : MonoBehaviour {

    // Global instance (throughout a game).
    public static GlobalScript Instance = null;

	void Awake () {
        if (Instance == null) {
            print("Initialize");
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
	}

    public void GameOver()
    {
        print("GameOver");
        Application.LoadLevel("main");
    }

    public void ReachedGoal()
    {
        print("ReachedGoal");
        Application.LoadLevel("main");
    }
}
