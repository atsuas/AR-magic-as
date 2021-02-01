using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public ParticleSystem particle;
    public ParticleSystem particle1;
    public AudioClip audioClip;
    public AudioClip audioClip1;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (transform.tag == "Power")
        {
            particle.Play();
            audioSource.clip = audioClip;
            audioSource.Play();
        }
        else if (transform.tag == "Bomb")
        {
            particle1.Play();
            audioSource.clip = audioClip1;
            audioSource.Play();
        }
    }
}
