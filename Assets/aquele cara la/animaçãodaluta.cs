using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class animaçãodaluta : MonoBehaviour
{
    [SerializeField] private Animator animatorlutador;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction  andarparafrente;

    [SerializeField] private InputAction andarparatras;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;

        andarparafrente.Enable();
        andarparafrente.performed += Andando;

        andarparatras.Enable();
        andarparatras.performed += Aocontrario;
    }

    private void OnDestroy()
    { 
        ataque.performed -= Atacar;
        andarparafrente.performed -= Andando;
        andarparatras.performed -= Aocontrario;
    }
    
    public void Atacar(InputAction.CallbackContext context)
    {
        animatorlutador.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }

    public void Andando(InputAction.CallbackContext context)
    {
        animatorlutador.SetTrigger("Walk Forward");
        Debug.Log("Andando");
       
    }

    public void Aocontrario(InputAction.CallbackContext context)
    {
        animatorlutador.SetTrigger("Walk Backward");
        Debug.Log("Aocontrario");
    }
}
