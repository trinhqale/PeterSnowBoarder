using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowTrailControl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private ParticleSystem snowTrail;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            snowTrail.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            snowTrail.Stop();
        }
    }
}
