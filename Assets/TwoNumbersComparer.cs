using UnityEngine;
using UnityEngine.UI;

public class TwoNumbersComparer : MonoBehaviour
{
    public InputField number1Field;
    public InputField number2Field;
    public Text resultText;

    public void CompareNumbers()
    {
        float num1 = float.Parse(number1Field.text);
        float num2 = float.Parse(number2Field.text);

        if (num1 > num2)
        {
            resultText.text = "Первое число больше: " + num1.ToString();
        }
        else if (num1 < num2)
        {
            resultText.text = "Второе число больше: " + num2.ToString();
        }
        else
        {
            resultText.text = "Числа равны";
        }
    }
}
