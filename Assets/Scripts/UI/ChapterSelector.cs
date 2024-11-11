using TMPro;
using UnityEngine;

public class ChapterSelector : MonoBehaviour
{
    public TextMeshProUGUI chapterNameUI;
    public GameObject chaptersObj;
    public GameObject levelObj;
    public GameObject subMenuObj;
    public int lvl = 1;
    string[] chapterName = { "Kinematics","Collsion","Rotation","Laws of Motion","Gravitation" };
    void Start()
    {
        chapterNameUI.text = chapterName[lvl];
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void showLevel() { 
        chaptersObj.SetActive(false);
        levelObj.SetActive(true);
        subMenuObj.SetActive(true);
    }
}
