using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CarouselManager : MonoBehaviour
{
    public RectTransform[] instructionPanels; // Array to store instruction panels
    public float slideSpeed = 1.0f; // Speed of slide transition
    private int currentIndex = 0; // Index for the current panel being displayed

    // Method to slide to the next panel
    public void SlideToNextPanel()
    {
        if (currentIndex < instructionPanels.Length - 1)
        {
            currentIndex++;
            StartCoroutine(SlideToPanel(instructionPanels[currentIndex]));
        }
    }

    // Coroutine for sliding animation
    IEnumerator SlideToPanel(RectTransform targetPanel)
    {
        Vector3 startPos = instructionPanels[0].anchoredPosition;
        Vector3 endPos = targetPanel.anchoredPosition;

        float elapsedTime = 0f;
        while (elapsedTime < 1f)
        {
            elapsedTime += Time.deltaTime * slideSpeed;
            instructionPanels[0].anchoredPosition = Vector3.Lerp(startPos, endPos, elapsedTime);
            yield return null;
        }
    }
}
