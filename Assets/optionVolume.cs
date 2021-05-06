using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class optionVolume : MonoBehaviour
{
   public AudioSource aud;
   private float musicv = .25f;
   void Update(){
       aud.volume=musicv;
   }
    void Start(){
        DontDestroyOnLoad(aud);
    }

   public void updateVolume(float volume){
       musicv = volume;
   }
}
