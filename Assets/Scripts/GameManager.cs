using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text messageText;

    // Start is called before the first frame update
    void Start()
    {
        ShowMessage();   
    }

    private void ShowMessage()
    {
        messageText.text = string.Format("Welcome, {0} In our game scene", References.userName);
    }
}
