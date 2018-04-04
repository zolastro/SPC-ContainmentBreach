using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlinkService : MonoBehaviour {


    [SerializeField] private GameObject eyelids;
    [SerializeField] private Slider blinkMeter;

    private Animator eyelidsAnimator;

    private float timeSinceLastBlink;

    void Start () {
        this.eyelidsAnimator = this.eyelids.GetComponent<Animator>();	
	}

    public void Update()
    {
        this.timeSinceLastBlink += Time.deltaTime;
    }

    public void Blink() {
        this.timeSinceLastBlink = 0;
        this.eyelidsAnimator.SetTrigger("blink");
    }

    public float getTimeSinceLastBlink() {
        return this.timeSinceLastBlink;
    }
}
