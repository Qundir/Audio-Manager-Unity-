using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScript : MonoBehaviour
{  
    public GameObject panel;
    public void PlayCrashSFX()
    {
        //this code for example to how to use SFX sound
        AudioManager.Instance.PlaySFX("Crash");
    }
    public void PlayJumpSFX()
    {
        // important thing is must be same name with sfx sound name on audio manager
        AudioManager.Instance.PlaySFX("Jump");
    }
    public void PlayThemeMusic()
    {
        // Theme start on the AudioManager Start function this one example of it
        AudioManager.Instance.PlayMusic("Theme");
    }
    public void StopMusic()
    {

        // this code will stop the music and you can change the theme with that start it and play the another one
        AudioManager.Instance.musicSource.Stop();
    }
    
    public void SetSettingPanelActive()
    {
    if (panel != null)
        {
            bool isActive = panel.activeSelf;
            panel.SetActive(!isActive);
        }
    }

}

