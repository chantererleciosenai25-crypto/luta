using Unity.VisualScripting;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] AudioSource explosionSorce;
    [SerializeField] AudioClip explosionSoco1;
    public void playexplosion()
    {
        Debug.Log("play explosin");
        explosionSorce.clip = explosionSoco1;

        explosionSorce.Play();
    }


}
