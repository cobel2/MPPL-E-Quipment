using UnityEngine;
using System.Collections;

public class BackgroundMusic : MonoBehaviour {

    public AudioSource myAudio;

    public static GameObject bgmObject;

    void Awake()
    {
        if (bgmObject)
        {
            Destroy(gameObject);
            return;
        }

        myAudio.Play();
        bgmObject = gameObject;
    }
}
