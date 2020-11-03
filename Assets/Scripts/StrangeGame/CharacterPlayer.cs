using UnityEngine;

public class CharacterPlayer : CharacterBase
{
    [SerializeField] private Transform enemy;

    public void Update()
    {
        var dist = enemy.transform.position.x - transform.position.x;
        if (dist >= 1f || characterInfo.Speed < 0f)
            transform.Translate(Time.deltaTime * characterInfo.Speed * transform.forward, Space.World);
    }
}
