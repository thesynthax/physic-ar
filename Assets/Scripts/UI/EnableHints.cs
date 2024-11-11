using UnityEngine;

public class EnableHints : MonoBehaviour
{
    public int level_no;
    public GameObject closeButton;
    public GameObject hint01;
    public GameObject hint02;
    public GameObject hint03;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showHint()
    {
        if (level_no == 1) {
            hint01.SetActive(true);
            hint02.SetActive(false);
            hint03.SetActive(false);
            closeButton.SetActive(true);
        }
        if (level_no == 2)
        {
            hint01.SetActive(false);
            hint02.SetActive(true);
            hint03.SetActive(false);
            closeButton.SetActive(true);

        }
        else if (level_no == 3)
        {
            hint01.SetActive(false);
            hint02.SetActive(false);
            hint03.SetActive(true);
            closeButton.SetActive(true);
        }

    }
}
