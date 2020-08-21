using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    public static AudioController instance;

    public AudioSource levelMusic, mainMenuMusic, winSound, loseSound, errorSound;

    private void Awake()
    {
        instance = this;
    }

    public void PlayLevelMusic()
    {
        levelMusic.Stop();
        levelMusic.Play();
    }

    public void PlayMainMenuMusic()
    {
        mainMenuMusic.Stop();
        mainMenuMusic.Play();
    }

    public void PlayWinSound()
    {
        winSound.Stop();
        winSound.Play();
    }

    public void PlayLoseSound()
    {
        loseSound.Stop();
        loseSound.Play();
    }
    public void PlayErrorSound()
    {
        errorSound.Stop();
        errorSound.Play();
    }
}
