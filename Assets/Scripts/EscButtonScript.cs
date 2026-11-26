using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;
public class EscButtonScript : MonoBehaviour
{
    [SerializeField] Button escButton;
    [SerializeField] GameObject screen2;

    public void EscButton()
    {
        screen2.SetActive(false);
    }

    public void OnClick()
    {
        EscButton();
    }



}
