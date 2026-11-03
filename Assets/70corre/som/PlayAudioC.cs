using System.Collections.Generic;
using UnityEngine;

public class PlayAudioC : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioSource GruntSource;
    [SerializeField] AudioSource Footstep;

    [SerializeField] AudioClip wooshSoco1;

    [SerializeField] List<AudioClip> Gruntra;
    [SerializeField] List<AudioClip> FootPasso;

    public void PlayWoosh()
    {
        Debug.Log("Play woosh");

        wooshSource.clip = wooshSoco1;
        wooshSource.Play();
    }

    public void PlayRa()
    {
        Debug.Log("RA");

        GruntSource.clip = Gruntra[Random.Range(0, Gruntra.Count)];
        GruntSource.pitch = Random.Range(0.9f, 1.6f);
        GruntSource.Play();
    }

    public void PlayFootStep()
    {
        Debug.Log("Play footstep");

        Footstep.clip = FootPasso[Random.Range(0, FootPasso.Count)];

        Footstep.pitch = Random.Range(0.9f, 1.6f);
        Footstep.Play();
    }
    }