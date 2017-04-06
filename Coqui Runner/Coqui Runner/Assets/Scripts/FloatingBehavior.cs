using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBehavior : MonoBehaviour {

    float coinYPosition;
    bool coinActive;

    public float floatStrength;

    private void OnEnable()
    {
        coinYPosition = transform.position.y;
        coinActive = true;
    }

    void Update () {
        if(coinActive)
        {
            transform.position = new Vector2(transform.position.x,
                coinYPosition + ((float)Mathf.Sin(Time.time) * floatStrength));
        }   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            coinActive = false;
        }
    }

}
