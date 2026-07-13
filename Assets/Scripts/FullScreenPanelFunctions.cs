using UnityEngine;

public class FullScreenPanelFunctions : MonoBehaviour
{
    public GameObject Panel;
    public GameObject HomePanel;
    public GameObject NavigationBar;

    public void OpenPanel(){
        if (Panel != null && HomePanel != null && NavigationBar != null){
            Panel.SetActive(true);
            HomePanel.SetActive(false);
            NavigationBar.SetActive(false);
        }
    }

    public void ClosePanel(){
        if (Panel != null && Panel.activeSelf && HomePanel != null && NavigationBar != null){
            Panel.SetActive(false);
            HomePanel.SetActive(true);
            NavigationBar.SetActive(true);
        }
    }
}
