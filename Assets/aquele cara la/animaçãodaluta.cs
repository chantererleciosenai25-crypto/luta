using System;
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

        andarparafrentes.canceled += Parar;
        andarparatras.canceled += PararT;
    }

    private void PararT(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Backward", false);
    }

    private void Parar(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Forward", false);
    }

    private void OnDestroy()
    { 
        ataque.performed -= Atacar;
        andarparafrente.canceled -= Andando;

        andarparatras.canceled -= Aocontrario;
    }
    
    public void Atacar(InputAction.CallbackContext context)
    {
        animatorlutador.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }

    public void Andando(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Forward", true);
        Debug.Log("Andando");
       
    }

    public void Aocontrario(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Backward",true);
        Debug.Log("Aocontrario");
    }
}
