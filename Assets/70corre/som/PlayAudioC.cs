using UnityEngine;

public class PlayAudioC : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioSource GruntSource;
    [SerializeField] AudioSource Footstep;
    [SerializeField] AudioClip wooshSoco1;
    [SerializeField] AudioClip FootPasso;
    [SerializeField] AudioClip Gruntra;

    public void PlayWoosh()
    {
        Debug.Log("Play woosh");

        wooshSource.clip = wooshSoco1;
        wooshSource.Play();
    }

    public void PlayRa()
   {
        Debug.Log("RA");

        GruntSource.clip = Gruntra;
        GruntSource.Play();


    }
    public void PlayFootStep()
    {
        Debug.Log("Play footstep");

        Footstep.clip = FootPasso;
        Footstep.Play();
    }
}