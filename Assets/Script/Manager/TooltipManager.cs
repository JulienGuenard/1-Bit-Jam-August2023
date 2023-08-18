using TMPro;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{
    public GameObject   tooltip;
    TextMeshProUGUI     tooltipText;

    public float xOffset;

    Vector3 posOrigin;

    static public TooltipManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        tooltipText = tooltip.GetComponent<TextMeshProUGUI>();
        tooltipText.enabled = false;

        posOrigin = tooltip.transform.localPosition;
    }

    public void ShowTooltipAtPos(string message, Transform trans)
    {
        tooltip.transform.localPosition = new Vector3(trans.position.x + xOffset, posOrigin.y, 0);
        ShowTooltip(message);
    }

    public void ShowTooltip(string message)
    {
        tooltipText.text = message;
        tooltipText.enabled = true;
    }

    public void HideTooltip()
    {
        tooltipText.text = " ";
        tooltipText.enabled = false;
    }
}
