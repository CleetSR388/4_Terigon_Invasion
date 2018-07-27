using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{

    [SerializeField] AudioClip impact;
    [SerializeField] AudioSource audioSource;

    private void OnCollisionEnter(Collision collision)
    {

        audioSource.PlayOneShot(impact, .7f);
    }

}