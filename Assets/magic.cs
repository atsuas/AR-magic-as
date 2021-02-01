using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public ParticleSystem particle;
    public ParticleSystem particle1;

    // Start is called before the first frame update
    void Start()
    {
        
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
        }
        else if (transform.tag == "Bomb")
        {
            particle1.Play();
        }
    }
}
