using UnityEngine;
using TMPro;

public class ShowInstructions : MonoBehaviour
{
    public Text​Mesh​Pro​UGUI inst;
    private string instruction = 
        "step 01 : Use the provided markers to set up your playing field.\r\n\n" +
        "step 02 : The source marker indicates where the ball will be launched, and the target marker represents where the ball should land.\r\n\n" +
        "step 03 : Adjust the distance between the source and target markers by moving the target marker to the correct position. \r\n\n" +
        "step 04 : Calculate the range of the projectile using initial velocity (​v0) and launch angle () and place the target marker at this distance to ensure the ball hits the target";
    public GameObject showInstructionsbox;
    public GameObject closeButton;

    void Start()
    {
        inst.text = instruction.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showInstructionsDialog()
    {
        showInstructionsbox.SetActive(true);
        closeButton.SetActive(true);
    }
}
