using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TheCalculator : MonoBehaviour
{

    #region Fields
    public TextMeshProUGUI InputText;
    private float m_result;
    private float m_input;
    private float m_inputSecond;
    private string m_operation;
    #endregion Fields

    #region Methods
    void Start()
    {
        
    }

    public void ClickNumber(int val)
    {
        Debug.Log(message: $"check val: {val}");
        InputText.text = $"{val}";
        if(m_input == 0)
        {
            m_input = val;
        }
        else
        {
            m_inputSecond = val;
        }
        
    }
    public void ClickOperation(string val)
    {
        Debug.Log(message: $"ClickOperation val: {val}");
        m_operation = val;
    }
    public void ClickEqual(string val)
    {
        Debug.Log(message: $"ClickEqual val: {val}");
        if(m_input != 0 && m_inputSecond != 0 && !string.IsNullOrEmpty(m_operation))
        {
            switch(m_operation)
            {
                case "+":
                    m_result = m_input + m_inputSecond;
                    break;

                case "-":
                    m_result = m_input - m_inputSecond;
                    break;

                case "*":
                    m_result = m_input * m_inputSecond;
                    break;

                case "/":
                    m_result = m_input / m_inputSecond;
                    break;
            }
            InputText.SetText(m_result.ToString());
            ToClearInput();
        }
    }
    public void ClickPeriod(string val)
    {
        Debug.Log(message: $"ClickPeriod val: {val}");
    }
    private void ToClearInput()
    {
        m_input = 0;
        m_inputSecond = 0;
    }
    #endregion Methods

    #region Events
    #endregion Events

}
