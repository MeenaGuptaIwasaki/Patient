﻿using UnityEngine;
using System.Collections;

public class CameraInvertAction : ActionRunner {

	private bool finished;
	private CameraInvert invert;
	
	public CameraInvertAction() {
		finished = false;
		invert = Camera.main.GetComponent<CameraInvert>();
	}
	
	// Start the action.
	public override void Start() {
		invert.Inverted = true;
	}
	
	// Message prints immediately, so there's nothing to interrupt
	public override void Interrupt() {
		invert.Restore ();
		finished = true;
	}
	
	// We're finished as soon as we start
	public override bool IsFinished() {
		return finished;
	}
}
