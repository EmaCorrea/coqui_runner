using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour {

    private SpriteRenderer newSprite;

	// Use this for initialization
	void Start () {
        newSprite = GetComponent<SpriteRenderer>();
        //newSprite.color = Color.green;
    }

}
