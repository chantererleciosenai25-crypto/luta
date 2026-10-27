using UnityEngine;

public class PlayAudioC : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioSource Footstep;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioClip FootPasso;

    public void PlayWoosh()
    {
        Debug.Log("Play woosh");

        wooshSource.clip = wooshSoco1;
        wooshSource.Play();
    }

    public void PlayFootStep()
    {
        Debug.Log("Play footstep");

        Footstep.clip = FootPasso;
        Footstep.Play();
    }
}