using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlinkService : MonoBehaviour {


    [SerializeField] private GameObject eyelids;
    [SerializeField] private float blinkRate;

    private Animator eyelidsAnimator;

    private float timeSinceLastBlink;

    void Start () {
        this.eyelidsAnimator = this.eyelids.GetComponent<Animator>();	
	}

    public void Update()
    {
        this.timeSinceLastBlink += Time.deltaTime;
        if (this.timeSinceLastBlink > blinkRate)
        {
            this.Blink();
        }
    }

    public void Blink() {
        this.timeSinceLastBlink = 0;
        this.eyelidsAnimator.SetTrigger("blink");
    }

    public float getTimeSinceLastBlink() {
        return this.timeSinceLastBlink;
    }

    public bool isBlinking() {
        return this.timeSinceLastBlink > 0.1 && this.timeSinceLastBlink < 0.2;
    }
}
