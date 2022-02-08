using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableObjects/LevelList")]
public class LevelsSO : ScriptableObject
{
    public List<Level> Levels;

    [System.Serializable]
    public class Level
    {
        public int _levelNumber;
        public string _sceneName; //:(
    }
}
