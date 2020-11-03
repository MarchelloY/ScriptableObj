using System;
using UnityEngine;

[CreateAssetMenu]
public class FloatVariable : ScriptableObject, ISerializationCallbackReceiver
{
    public event Action<float> OnValueChanged;
    [SerializeField] private float initialValue;

    private float _value;

    public float Value
    {
        get => _value;
        set
        {
            _value = value;
            OnValueChanged?.Invoke(value);
        }
    }

    public float InitialValue => initialValue;

    public void OnBeforeSerialize() {}

    public void OnAfterDeserialize()
    {
        _value = initialValue;
    }
}