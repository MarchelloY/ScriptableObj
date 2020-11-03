using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class SoundGroup : ScriptableObject
{
    [SerializeField] private string id;
    [SerializeField] private SoundInfo[] sounds;

    public string ID => id;

    public string[] GetIds()
    {
        return sounds.Select(sound => sound.ID).ToArray();
    }

    public SoundInfo GetSoundInfo(string soundId)
    {
        return sounds.FirstOrDefault(sound => sound.ID == soundId);
    }
}
