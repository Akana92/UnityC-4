using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField number1Field;
    public InputField number2Field;
    public Text resultText;

    public void Add()
    {
        float num1 = float.Parse(number1Field.text);
        float num2 = float.Parse(number2Field.text);
        float result = num1 + num2;
        resultText.text = result.ToString();
    }

    public void Subtract()
    {
        float num1 = float.Parse(number1Field.text);
        float num2 = float.Parse(number2Field.text);
        float result = num1 - num2;
        resultText.text = result.ToString();
    }

    public void Multiply()
    {
        float num1 = float.Parse(number1Field.text);
        float num2 = float.Parse(number2Field.text);
        float result = num1 * num2;
        resultText.text = result.ToString();
    }

    public void Divide()
    {
        float num1 = float.Parse(number1Field.text);
        float num2 = float.Parse(number2Field.text);
        if (num2 != 0)
        {
            float result = num1 / num2;
            resultText.text = result.ToString();
        }
        else
        {
            resultText.text = "Cannot divide by zero";
        }
    }
}
