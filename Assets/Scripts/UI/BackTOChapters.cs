using UnityEngine;
using TMPro;
public class BackTOChapters : MonoBehaviour
{
    public TextMeshProUGUI chapterNameUI;
    public GameObject chaptersObj;
    public GameObject levelObj;
    public GameObject subMenuObj;
    void Start()
    {
        chapterNameUI.text = "Chapters";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void closeLevel()
    {
        chaptersObj.SetActive(true);
        levelObj.SetActive(false);
        subMenuObj.SetActive(false);
    }
}
