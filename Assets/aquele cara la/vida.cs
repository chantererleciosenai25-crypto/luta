using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float maxHp = 100f;
    [SerializeField] private InputAction debugDano;
    [SerializeField] private Image Hpbar;
    [SerializeField] private Image HpbarFeedback;

    [Header("Feedback")]
    [SerializeField] private float velocidadeFeedback = 0.5f;
    [SerializeField] private float atrasoFeedback = 0.5f;

    private float hp;

    private void Start()
    {
        hp = maxHp;
        AttBarraVida();
        debugDano.Enable();
    }

    private void Update()
    {
#if UNITY_EDITOR
        if (debugDano.WasPressedThisFrame())
        {
            TomarDano(15f);
        }
#endif
    }

    public void TomarDano(float quantidadeDano)
    {
        hp -= quantidadeDano;
        hp = Mathf.Clamp(hp, 0, maxHp);

        AttBarraVida();
    }

    public void AttBarraVida()
    {
        Hpbar.fillAmount = hp / maxHp;

        StopAllCoroutines();
        StartCoroutine(AtualizarFeedback());
    }

    private IEnumerator AtualizarFeedback()
    {
        yield return new WaitForSeconds(atrasoFeedback);

        while (HpbarFeedback.fillAmount > Hpbar.fillAmount)
        {
            HpbarFeedback.fillAmount = Mathf.MoveTowards(
                HpbarFeedback.fillAmount,
                Hpbar.fillAmount,
                velocidadeFeedback * Time.deltaTime
            );

            yield return null;
        }
    }
}