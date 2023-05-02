using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Audio : MonoBehaviour
{

    public const string musicName = ""; // Gets the name of the .Wav file
    public AudioSource Music;
    public AudioClip musicClip;
    public string filepath;
    public bool loop;
    // Start is called before the first frame update
    void Awake()
    {
        Music = gameObject.AddComponent<AudioSource>();
        filepath = "file://" + Application.streamingAssetsPath + "/Sound/"; //Gets file location in folder
    }

    public IEnumerator LoadMusic()
    {
        WWW request = getAudioFile(filepath, musicName); //gets a Web page using audio file, returns it
        yield return request;

        musicClip = request.GetAudioClip(); // Sets the music Clip to be the File found
        musicClip.name = musicName; //Sets the name of the clip to the name of the .Wav file

        PlayMusic(); //calls method
    }

    public void PlayMusic()
    {
        Music.clip = musicClip; //Sets Source to the clip
        Music.Play();
        Music.loop = loop; //Calls bool to loop song
    }

    public WWW getAudioFile(string file, string path)
    {
        string audioload = string.Format(file + "{0}" + path); //Gets the Audio 
        WWW request = new WWW(audioload); //gets new and returns
        return request;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
