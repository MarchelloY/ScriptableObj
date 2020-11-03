using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class SoundConfig : ScriptableObject
{
    [SerializeField] private SoundGroup[] groups;

    public string[] GetGroupsIds()
    {
        return groups.Select(group => group.ID).ToArray();
    }
    
    public string[] GetSoundIds(string groupId)
    {
        var soundGroup = groups.FirstOrDefault(group => group.ID == groupId);
        return soundGroup == null ? null : soundGroup.GetIds();
    }

    public SoundInfo GetSoundInfo(string id)
    {
        foreach (var soundGroup in groups)
        {
            var sound = soundGroup.GetSoundInfo(id);
            if (sound != null) return sound;
        }
        return null;
    }
}
