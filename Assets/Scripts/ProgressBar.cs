using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ProgressBar : MonoBehaviour
{
    public int maximum;
    public int current;
    public Image mask;
    public TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill(){
        current = Mathf.Clamp(current, 0, maximum);
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;
        scoreText.text = (float)current + "/" + (float)maximum;

    }
}
