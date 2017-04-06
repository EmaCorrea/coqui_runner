using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour {

    public float speed;

    bool scrollerActive = true;

    float time = 0f;

    // Update is called once per frame
    void Update()
    {
        if(scrollerActive)
        {
            time += 0.05f;
            Vector2 offset = new Vector2(time * speed, 0);
            GetComponent<Renderer>().material.mainTextureOffset = offset;
        }
    }

    public void StopScrolling()
    {
        scrollerActive = false;
    }

    public void ResumeScrolling()
    {
        scrollerActive = true;
    }

    public void StartScrolling()
    {
        time = 0f;
        scrollerActive = true;
    }

}
