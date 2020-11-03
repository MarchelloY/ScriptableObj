using UnityEngine;
using UnityEngine.UI;

public abstract class CharacterBase : MonoBehaviour
{
    [SerializeField] protected CharacterInfo characterInfo;
    [SerializeField] private Image healthImage;

    protected float maxHp;

    private void OnEnable()
    {
        maxHp = characterInfo.Hp;
        OnHpChanged(maxHp);
        characterInfo.Hp.Variable.OnValueChanged += OnHpChanged;
    }

    private void OnDisable()
    {
        characterInfo.Hp.Variable.OnValueChanged -= OnHpChanged;
    }

    private void OnHpChanged(float hp)
    {
        healthImage.fillAmount = hp / maxHp;
    }
}
