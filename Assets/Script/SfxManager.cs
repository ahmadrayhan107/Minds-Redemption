using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine; 

public class sfxManager : MonoBehaviour
{
    public static sfxManager Instance;

    /* [SerializeField] private Sound[] suara;
    
    private void Awake(){
        Instance = this;

        foreach (Sound s in suara){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.audioClip;
            s.source.loop = s.isLoop;
            s.source.volume = s.volume;

            if(s.playOnAwake)
                s.source.Play();
        } */
    //}/* 

   /*  public void Play(string clipname){
        Sound s = Array.Find(suara, dummySound => dummySound.clipName == clipname);
        if (s == null){
            Debug.LogError("Sound: "+ clipname +"doesnt exist");
            return;
        }
        s.source.Play();
    }

    public void Stop(string clipname){
        Sound s = Array.Find(suara, dummySound => dummySound.clipName == clipname);
        if (s == null){
            Debug.LogError("Sound: " + clipname +"doesnt exist");
            return;
        }
        s.source.Stop();
    } */ 
}
