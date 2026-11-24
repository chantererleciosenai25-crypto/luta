using UnityEngine;

public class ataque : MonoBehaviour
{
    [SerializeField] private Transform maoDireita;
    [SerializeField] private float socoDireitoAlcance = 0.5f;
    [SerializeField] private LayerMask playerMask;


    public void socoDireita()
    {
        Collider[] acertos = Physics.OverlapSphere(maoDireita.position, socoDireitoAlcance, playerMask); 

        foreach (Collider c in acertos)
        {
            if (c.transform != this.transform)
            {
                c.transform.GetComponent<HP>().TomarDano(10f);
            }
        }
    }
}

   