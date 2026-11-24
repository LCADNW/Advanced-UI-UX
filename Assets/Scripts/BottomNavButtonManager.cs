using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
public class BottomNavButtonManager : MonoBehaviour
{
    [SerializeField] Button escButton;

    public void EscButton()
    {
        Debug.Log("you somehow did it.");
        Application.Quit();
    }

    public void OnClick()
    {
        EscButton();
    }



}
