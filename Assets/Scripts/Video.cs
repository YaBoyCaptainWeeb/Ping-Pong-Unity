using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    private SpriteRenderer video;
    private VideoPlayer player;

    private void Awake()
    {
        video = GetComponent<SpriteRenderer>();
        player = GetComponent<VideoPlayer>();
        player.loopPointReached += FinishVideo;

    }
    private void FinishVideo(VideoPlayer vp)
    {
        video.enabled = false;
    }

    public void PlayVideo()
    {
        video.enabled = true;
        player.Play();
    }
}
