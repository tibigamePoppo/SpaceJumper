using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI textMeshPro;
    private int time = 0;
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        StartCoroutine(TimeCountUp());
    }

    public void StopTimer()
    {
        StopCoroutine(TimeCountUp());
    }

    IEnumerator TimeCountUp()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time++;
            ViewText();
        }
    }

    private void ViewText()
    {
        textMeshPro.text = $"{ time / 60}:{time % 60}";
    }
}
