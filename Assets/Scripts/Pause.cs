﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool pause = false;
	private Canvas cvsPause;

    public Gun scriptGun;

	// Use this for initialization
	void Start () {
		cvsPause = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Submit")) {
			pause = !pause;
		}

		if (pause) {
			cvsPause.enabled = true;
			Time.timeScale = 0;
            scriptGun.ActivePause(true);
		} else {
			cvsPause.enabled = false;
			Time.timeScale = 1;
            scriptGun.ActivePause(false);
		}
		
	}

	public void QuitToMenu(){
		Application.LoadLevel(0);
	}

	public void Restart(){
		Application.LoadLevel (Application.loadedLevel);
	}

	public void ReturnGame(){
		pause = false;
	}
}
