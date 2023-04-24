using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Audio : MonoBehaviour
{
    public const string musicName = "";
    public AudioSource Music;
    public AudioClip musicClip;
    public string filepath;

    // Start is called before the first frame update
    void Awake()
    {
        Music = gameObject.AddComponent<AudioSource>();
        filepath = "file://" + Application.streamingAssetsPath + "/Sound/";
    }

    public IEnumerator LoadMusic()
    {
        WWW request = getAudioFile(filepath, musicName);
        yield return request;

        musicClip = request.GetAudioClip();
        musicClip.name = musicName;

        PlayMusic();
    }

    public void PlayMusic()
    {
        Music.clip = musicClip;
        Music.Play();
    }

    public WWW getAudioFile(string file, string path)
    {
        string audioload = string.Format(file + "{0}" + path);
        WWW request = new WWW(audioload);
        return request;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
