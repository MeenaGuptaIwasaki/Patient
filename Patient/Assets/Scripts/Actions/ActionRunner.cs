﻿using UnityEngine;
using System.Collections;

public delegate void OnFinished();

public abstract class ActionRunner {

	protected OnFinished onFinished;
	bool finished;

	public ActionRunner() {
		finished = false;
	}

	//register functions to be called when action finishes
	public void register(OnFinished func){
		if (onFinished == null) {
			onFinished = func;
		} else {
			onFinished += func;
		}
	}

	//to be called when action finishes
	protected void done(){
		if (onFinished != null) {
			onFinished ();
		}
		finished = true;
	}

	public abstract void Start ();
		// Start the action.
	
	public abstract void Interrupt ();
		// Stop the action in-progress.
	
	// TODO: maybe convert to abstract class?
	public virtual bool IsFinished(){
		return finished;
	}

}
