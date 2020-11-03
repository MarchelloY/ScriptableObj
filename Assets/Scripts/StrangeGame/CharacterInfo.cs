using UnityEngine;

[CreateAssetMenu]
public class CharacterInfo : ScriptableObject
{
    [SerializeField] private FloatReference hp;
    [SerializeField] private FloatReference speed;

    public FloatReference Hp => hp;
    public FloatReference Speed => speed;
}
