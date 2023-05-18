using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{

    public static AudioSource Deathsound;
    public static AudioSource Gemsound;
    public static AudioSource Winsound;

    // Start is called before the first frame update
    void Start()
    {
        Deathsound = GetComponent<AudioSource>();
        Gemsound = GetComponent<AudioSource>();
        Winsound = GetComponent<AudioSource>();
    }
}
