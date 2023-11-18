using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI promptText;

    // Start is called before the first frame update
    void Start()
    {
        //promotText.text = "Welcome"
    }

    public void UpdateText(string promtMessage)
    {
        promptText.text = promtMessage;
    }
}
