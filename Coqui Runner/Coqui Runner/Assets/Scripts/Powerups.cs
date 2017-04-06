using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour {

    public bool doublePoints;

    public float powerupLength;

    private PowerupManager thePowerupManager;

    private AudioSource powerupSound;

	// Use this for initialization
	void Start () {
        thePowerupManager = FindObjectOfType<PowerupManager>();
        powerupSound = GameObject.Find("PowerupSound").GetComponent<AudioSource>();
        powerupSound.volume = 0.15f;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            thePowerupManager.ActivatePowerup(doublePoints, powerupLength);
            powerupSound.Play();
        }
        gameObject.SetActive(false);

    }

}
