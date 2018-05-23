﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeCrate : MonoBehaviour {

    public int grenadeAmount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.SendMessage("GainGrenade", grenadeAmount, SendMessageOptions.DontRequireReceiver);
        Debug.Log("Grenade Crate detected : " + grenadeAmount.ToString());
        AfterTriggerEnter();
    }

    private void AfterTriggerEnter()
    {
        Destroy(gameObject);
    }


}
