using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    /// <summary>
    /// Generic Change UI text
    /// </summary>
    /// <param name="targetText"></param>
    /// <param name="text"></param>
    /// <param name="newValue"></param>
    public static void UpdateText(TextMeshProUGUI targetText, string text, int newValue)
    {
        targetText.text = text + newValue;
    }

    /// <summary>
    /// Show target btn
    /// </summary>
    /// <param name="onButton"></param>
    public static void EnableElement(GameObject onElement)
    {
        onElement.SetActive(true);
    }

    /// <summary>
    /// Hide target btn
    /// </summary>
    /// <param name="offButton"></param>
    public static void HideElement(GameObject offElement)
    {
        offElement.SetActive(false);
    }
}
