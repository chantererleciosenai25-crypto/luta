using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class LutadorControle : MonoBehaviour
{
    [SerializeField] private Animator animatorLutador;
    [SerializeField] private InputAction ataque;
    [SerializeField] private InputAction andar_Frente;
    [SerializeField] private InputAction andar_tras;
    void Start()
    {
        ataque.Enable();
        andar_Frente.Enable();
        andar_tras.Enable();
        ataque.performed += Atacar;
        andar_Frente.performed += Andar;
        andar_tras.performed += AndarT;
        andar_Frente.canceled += Parar;
        andar_tras.canceled += ParaT;
    }

    private void ParaT(InputAction.CallbackContext context)
    {
        animatorLutador.SetBool("Walk Backward", false);
    }

    private void Parar(InputAction.CallbackContext context)
    {
        animatorLutador.SetBool("Walk Forward", false);
    }

    private void OnDestroy()
    {
        ataque.performed -= Atacar;
        andar_Frente.canceled -= Andar;

    }
    public void Atacar(InputAction.CallbackContext context)
    {
        animatorLutador.SetTrigger("PunchTrigger");
        Debug.Log("Atacando");
    }
    public void Andar(InputAction.CallbackContext context)
    {
        animatorLutador.SetBool("Walk Forward", true);
        Debug.Log("andando");
    }
    public void AndarT(InputAction.CallbackContext context)
    {
        animatorLutador.SetBool("Walk Backward", true);
        Debug.Log("andando_para tras");
    }
}