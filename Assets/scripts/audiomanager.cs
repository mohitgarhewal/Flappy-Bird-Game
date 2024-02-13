using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiomanager : MonoBehaviour
{
    [Header("Audio source")]
    [SerializeField] AudioSource musicSource;
  

    [Header("Audio clip")]
    public AudioClip background;
   

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

}
