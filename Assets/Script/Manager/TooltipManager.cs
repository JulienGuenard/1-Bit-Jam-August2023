using TMPro;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public GameObject   tooltipItem;
    public GameObject   tooltipAction;
    TextMeshProUGUI     tooltipItemText;
    TextMeshProUGUI     tooltipActionText;

    public float xOffset;

    Vector3 tooltipItemPosOrigin;

    static public TooltipManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        tooltipItemText = tooltipItem.GetComponent<TextMeshProUGUI>();
        tooltipItem.SetActive(false);
        tooltipActionText = tooltipAction.GetComponentInChildren<TextMeshProUGUI>();
        tooltipAction.SetActive(false);

        tooltipItemPosOrigin = tooltipItem.transform.localPosition;
    }

    public void ShowTooltipItemAtPos(string message, Transform trans)
    {
        ShowTooltipItem(message);
    }

    public void ShowTooltipItem(string message)
    {
        tooltipItemText.text = message;
        tooltipItem.SetActive(true);
    }

    public void HideTooltipItem()
    {
        tooltipItemText.text = " ";
        tooltipItem.SetActive(false);
    }

    public void ShowTooltipAction(string message)
    {
        tooltipActionText.text = message;
        tooltipAction.SetActive(true);
    }

    public void HideTooltipAction()
    {
        tooltipAction.SetActive(false);
    }
}
