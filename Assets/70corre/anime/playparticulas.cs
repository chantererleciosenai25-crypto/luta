using UnityEngine;
using UnityEngine.VFX;
public class PersonagemParticulas : MonoBehaviour
{
    [SerializeField] private ParticleSystem soco;
    public void PlaySocoParticula()
    {
        soco.Play();
    }
}