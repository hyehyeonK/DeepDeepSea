﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour {
	public float positionX;
	private const float startPositionY = -14.0f;
	private const float endPositionY = 11.6f;
	// Update is called once per frame
	void Update () {

		transform.Translate(0, 0.05f, 0);
		Debug.Log(transform.localPosition.y + "");
		if( transform.localPosition.y > endPositionY)
		{
			transform.localPosition = new Vector3(positionX,startPositionY,0);
		}
	}
}
