using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

[RequireComponent(typeof(Button))]
public class MenuLevelButton : MonoBehaviour
{
    [SerializeField] TMP_Text _text;

    private Button _button;
    private string _sceneName;

    public void InitLevelButton(int levelNumber ,string sceneName)
    {
        _sceneName = sceneName;
        _text.text = levelNumber.ToString();
        _button.onClick.AddListener(LoadLevel);
    }

    private void LoadLevel() => SceneManager.LoadSceneAsync(_sceneName);

    private void Awake() => _button = GetComponent<Button>();
}
