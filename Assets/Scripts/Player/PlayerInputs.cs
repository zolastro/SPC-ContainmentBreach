using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour {

    private BlinkService blinkService;

    void Start () {
        this.blinkService = this.GetComponent<BlinkService>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            this.blinkService.Blink();
        }
	}
}
