using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class FinalVideoManager : MonoBehaviour
{
    public VideoPlayer video;

    void Start()
    {
        video.loopPointReached += EndVideo;
    }

    void EndVideo(VideoPlayer vp)
    {
        SceneManager.LoadScene("Menu");
    }
}