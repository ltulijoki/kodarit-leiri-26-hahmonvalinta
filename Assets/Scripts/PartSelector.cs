using UnityEngine;

public class PartSelector : MonoBehaviour
{
    public Sprite[] options;
    private SpriteRenderer targetRenderer;
    private int currentIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        targetRenderer = GetComponent<SpriteRenderer>();
    }

    public void Next()
    {
        currentIndex++;
        if (currentIndex >= options.Length) currentIndex = 0;
        targetRenderer.sprite = options[currentIndex];
    }

    public void Previous()
    {
        currentIndex--;
        if (currentIndex < 0) currentIndex = options.Length - 1;
        targetRenderer.sprite = options[currentIndex];
    }

    public void SetColor(Color color)
    {
        targetRenderer.color = color;
    }

    public Color GetColor()
    {
        return targetRenderer.color;
    }

    public void SetIndex(int newIndex)
    {
        currentIndex = newIndex;
        targetRenderer.sprite = options[currentIndex];
    }

    public int GetIndex()
    {
        return currentIndex;
    }
}
