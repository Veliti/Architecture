using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] LevelsSO _levels;
    [SerializeField] MenuLevelButton _buttonPrefab;
    [SerializeField] LayoutGroup _levelList;

    private void Start()
    {
        if(_levels.Levels != null)
        {
            foreach (var level in _levels.Levels)
            {
                var button = Instantiate(_buttonPrefab, _levelList.transform);
                button.InitLevelButton(level._levelNumber, level._sceneName);
            }
        }
    }

}
