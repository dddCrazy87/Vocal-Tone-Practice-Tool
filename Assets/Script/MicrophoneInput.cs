using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MicrophoneInput : MonoBehaviour {

    [SerializeField] private AudioSource Audio;
    public AudioMixerGroup mixerGroup;
    private AudioClip recordedClip;

    public void StartRecording() {
        int sampleRate = AudioSettings.outputSampleRate;
        Audio.clip = Microphone.Start(null, true, 10, sampleRate);
        Audio.loop = true;
        Audio.outputAudioMixerGroup = mixerGroup;
        Audio.Play();
    }

    public void StopRecording() {
        Audio.Stop();
        Microphone.End(null);
        recordedClip = Audio.clip;
    }

}
