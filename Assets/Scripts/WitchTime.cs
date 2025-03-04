using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
            StartCoroutine(SlowMo());
        }
    }

    IEnumerator SlowMo()
    {
        AudioSource src = AudioManager.instance.PlayAudio(clip, "aaa");
        Time.timeScale = .25f;

        while (src.isPlaying)
        {
            yield return null;
        }

        Time.timeScale = 1;
    }
}
