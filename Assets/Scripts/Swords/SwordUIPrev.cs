using UnityEngine;
using UnityEngine.UI;

public class SwordUIPrev : MonoBehaviour
{
    [SerializeField] private SwordData swordData;
    
    [SerializeField] private Transform rootPoint;
    [SerializeField] private Text nameLabel;
    [SerializeField] private Text descriptionLabel;
    [SerializeField] private Image iconLabel;
    [SerializeField] private Text costLabel;
    [SerializeField] private Text damageLabel;

    private GameObject swordObj;
    
    // Start is called before the first frame update
    private void Start()
    {
        SetupData();
        
    }

    // Update is called once per frame
    private void Update()
    {
        rootPoint.Rotate(Time.deltaTime * swordData.RotationSpeed* Vector3.up,Space.World);
    }

    public void SetupData()
    {
        if(swordObj != null) Destroy(swordObj);
        Instantiate(swordData.Prefab, rootPoint);
        nameLabel.text = swordData.SwordName;
        descriptionLabel.text = swordData.Description;
        iconLabel.sprite = swordData.Icon;
        costLabel.text = $"Cost: {swordData.Cost}";
        damageLabel.text = $"Damage: {swordData.Damage}";
    }
}
