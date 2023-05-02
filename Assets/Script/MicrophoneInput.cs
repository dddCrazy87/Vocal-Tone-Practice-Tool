using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MicrophoneInput : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;

    public void StartRecording() {
        int sampleRate = AudioSettings.outputSampleRate;
        Audio.clip = Microphone.Start(null, true, 10, sampleRate);
        Audio.loop = true;
        Audio.Play();
    }

    public void StopRecording() {
        Audio.Stop();
        Microphone.End(null);
    }
}
