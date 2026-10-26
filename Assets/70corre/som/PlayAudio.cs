using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] AudioSource wooshSource;
    [SerializeField] AudioClip wooshSoco1;

    public void PlayWoosh()
    {
        Debug.Log("Play woosh");

        wooshSource.clip = wooshSoco1;
        wooshSource.Play();
    }
}