#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class AnimeCharacterController : MonoBehaviour
{
    [SerializeField] private AnimeCharacterData data;
    [SerializeField] private Transform[] legs;
    [SerializeField] private Transform[] knees;
    [SerializeField] private Transform chest;
    [SerializeField] private Transform neck;
    [SerializeField] private Transform[] breasts;

    private void Start()
    {
        UpdateCharacter();
    }
    
#if UNITY_EDITOR
    private void Update()
    {
        if(Selection.activeGameObject != gameObject) return;
        UpdateCharacter();
    }
#endif
    
    private void UpdateCharacter()
    {
        foreach (var leg in legs) leg.localScale = data.GetLegSize(leg.localScale);
        foreach (var knee in knees) knee.localScale = data.GetKneeSize(knee.localScale);
        foreach (var breast in breasts) breast.localScale = data.BreastSize;
        chest.localScale = data.ChestSize;
        neck.localScale = data.NeckSize;
        
    }
}
