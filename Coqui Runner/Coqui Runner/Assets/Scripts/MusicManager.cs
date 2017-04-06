using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    private static MusicManager instance = null;

    public AudioSource bgMusic;

    void Start()
    {
        bgMusic.volume = 0.1f;
    }

    public static MusicManager Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
