using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTextBox : MonoBehaviour
{
    [SerializeField]
    Text dialog;
    [SerializeField]
    string message;
    [SerializeField, Range(0.001f, 4f)]
    float animationSpeed;
    IEnumerator animateText;

    public void ClearText()
    {
        dialog.text = "";
    }

    public void ShowDialog()
    {
        animateText = Animate(animationSpeed);
        StartCoroutine(animateText);
    }
    public string Message { get => message; set => message = value; }

    IEnumerator Animate(float time)
    {
        int i = 0;
        while (i < message.Length - 1)
        {
            dialog.text += message[i];
            i++;
            yield return new WaitForSeconds(time);
        }
    }
}
