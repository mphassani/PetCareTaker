using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUIComponent : MonoBehaviour
{
    public LinearIndicator statsBar;
    public Text statsText;
    private int textValue;

    void Start()
    {

    }

    public void SetValueTo(int value)
    {
        textValue = value;
        statsBar.SetValue(value);
        SetValueTextTo(value);
    }

    private void SetValueTextTo(int value)
    {
        statsText.text = "" + value;
    }
}
