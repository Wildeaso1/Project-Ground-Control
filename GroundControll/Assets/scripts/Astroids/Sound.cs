using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    public AudioClip Playsound;
    // Start is called before the first frame update
    

    public void PlayEffect()
    {
        AudioSource.PlayClipAtPoint(Playsound, transform.position);
    }
}
