using UnityEngine;

public class CloseAll : MonoBehaviour
{
    public GameObject closeButton;
    public GameObject hint01;
    public GameObject hint02;
    public GameObject hint03;
    public GameObject showInstructionsbox;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void closeAllDialogs()
    {
            hint01.SetActive(false);
            hint02.SetActive(false);
            hint03.SetActive(false);
            showInstructionsbox.SetActive(false);
            closeButton.SetActive(false);

    }
}
