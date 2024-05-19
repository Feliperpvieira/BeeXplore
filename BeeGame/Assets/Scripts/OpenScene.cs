using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class OpenScene : MonoBehaviour
{

    public string levelName;
    public VideoPlayer vid;


    void Start() {
        vid.loopPointReached += CheckOver;
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp)
    {
        SelectScene();
    }

    public void SelectScene()
    {
        SceneManager.LoadScene(levelName);
    }

}
