using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BlinkService : MonoBehaviour {


    [SerializeField] private GameObject eyelids;
    [SerializeField] private Slider blinkMeter;

    private Animator eyelidsAnimator; 

    void Start () {
        this.eyelidsAnimator = this.eyelids.GetComponent<Animator>();	
	}
	
    public void Blink() {
        this.eyelidsAnimator.SetTrigger("blink");
    }
}
