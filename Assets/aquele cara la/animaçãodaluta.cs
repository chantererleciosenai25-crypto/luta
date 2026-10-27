using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class animaçãodaluta : MonoBehaviour
{
    [SerializeField] private Animator animatorlutador;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction andarparafrente;
    [SerializeField] private InputAction andarparatras;

    void Start()
    {
        ataque.Enable();
        ataque.performed += Atacar;

        andarparafrente.Enable();
        andarparafrente.performed += Andando;
        andarparafrente.canceled += Parar;

        andarparatras.Enable();
        andarparatras.performed += Aocontrario;
        andarparatras.canceled += PararT;
    }

    private void OnDestroy()
    {
        ataque.performed -= Atacar;
        ataque.Disable();

        andarparafrente.performed -= Andando;
        andarparafrente.canceled -= Parar;
        andarparafrente.Disable();

        andarparatras.performed -= Aocontrario;
        andarparatras.canceled -= PararT;
        andarparatras.Disable();
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

    private void Parar(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Forward", false);
    }

    public void Aocontrario(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Backward", true);
        Debug.Log("Aocontrario");
    }

    private void PararT(InputAction.CallbackContext context)
    {
        animatorlutador.SetBool("Walk Backward", false);
    }
}
