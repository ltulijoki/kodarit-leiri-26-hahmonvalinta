using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public PartSelector hair;
    public PartSelector head;
    public PartSelector eyes;
    public PartSelector mouth;
    public PartSelector body;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadCharacter();
    }

    public void SaveCharacter()
    {
        SavePart(hair, "hair");
        SavePart(head, "head");
        SavePart(eyes, "eyes");
        SavePart(mouth, "mouth");
        SavePart(body, "body");
        SceneManager.LoadScene("Game");
    }

    void SavePart(PartSelector part, string name)
    {
        PlayerPrefs.SetInt(name + "Index", part.GetIndex());
        PlayerPrefs.SetString(name + "Color", ColorUtility.ToHtmlStringRGB(part.GetColor()));
    }

    void LoadPart(PartSelector part, string name)
    {
        int index = PlayerPrefs.GetInt(name + "Index", 0);
        string colorString = PlayerPrefs.GetString(name + "Color", "FFFFFF");
        part.SetIndex(index);
        if (ColorUtility.TryParseHtmlString("#" + colorString, out Color color))
            part.SetColor(color);
    }

    public void LoadCharacter()
    {
        LoadPart(hair, "hair");
        LoadPart(head, "head");
        LoadPart(eyes, "eyes");
        LoadPart(mouth, "mouth");
        LoadPart(body, "body");
    }
}
