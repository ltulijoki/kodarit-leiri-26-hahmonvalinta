using UnityEngine;
using UnityEngine.UI;

public class ColorManager : MonoBehaviour
{
    private PartSelector partSelector;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var button in GetComponentsInChildren<Button>())
        {
            button.onClick.AddListener(() =>
            {
                var color = button.GetComponent<Image>().color;
                partSelector?.SetColor(color);
            });
        }
    }

    public void SelectPart(PartSelector partSelector)
    {
        this.partSelector = partSelector;
    }
}
