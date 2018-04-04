using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlink : MonoBehaviour {

    [SerializeField] private float blinkRate;

    private BlinkService blinkService;

	void Start () {
        this.blinkService = this.GetComponent<BlinkService>();
	}
	
	void Update () {
        if (this.blinkService.getTimeSinceLastBlink() > blinkRate) {
            this.blinkService.Blink();
        }
    }
}
