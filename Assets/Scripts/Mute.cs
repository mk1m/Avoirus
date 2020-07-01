using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    bool isMute;

    public void MuteButton()
    {
        isMute = !isMute;
        AudioListener.volume = isMute ? 0 : 1;
    }

}
