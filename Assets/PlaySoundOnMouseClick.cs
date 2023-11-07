using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnMouseClick : MonoBehaviour
{
    public AudioClip clickSound; // Ŭ���� �� ����� ����
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}
