using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class endMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject endMenuUI;
    public GameObject playerUI;
    public static bool hasGameOverOccurred = false;
    public static bool endHealth = false;
    public healthbar healthbar;
    public GameObject targetObject;
    public GameObject playMenuUI;

    void Update()
    {


        if (!hasGameOverOccurred && playerHealth.currentHealth <= 0)
        {
            hasGameOverOccurred = true;
            Time.timeScale = 0.8f;
            Invoke("ShowEndMenu", 0.9f);
        }
        
        

        if(hasGameOverOccurred && playerHealth.currentHealth == 10)
        {
            endMenuUI.SetActive(false);
            Time.timeScale = 1f;

        }
    }

    void ShowEndMenu()
    {
        endMenuUI.SetActive(true);
        Time.timeScale = 0f;
        
    }
   

    
    public void RestartGame()
    {


        
        
        SceneManager.LoadScene("starter scene", LoadSceneMode.Additive);
        SceneManager.LoadScene("floor1");


        endMenuUI.SetActive(false);
        playerUI.SetActive(true);
        
        door.k1 = 0;
        door2.k2 = 0;
        door3.k3 = 0;
        door4.k4 = 0;
        door5.k5 = 0;
        door6.k6 = 0;
        door7.k7 = 0;

        door8.k8 = 0;

        door9.k9 = 0;
        door10.k10 = 0;

        power2.power = 1;
        trigger2.istrigger = false;
        hasGameOverOccurred = false;
        
        
        endHealth = true;
        playerHealth.playerAlive = true;




        targetObject.transform.position = new Vector3(-12.21f, -7.24f, -0.01482391f);

    }

    public void playGame()
    {




        SceneManager.LoadScene("starter scene", LoadSceneMode.Additive);
        SceneManager.LoadScene("floor1");


        playMenuUI.SetActive(false);
        playerUI.SetActive(true);

        door.k1 = 0;
        door2.k2 = 0;
        door3.k3 = 0;
        door4.k4 = 0;
        door5.k5 = 0;
        door6.k6 = 0;
        door7.k7 = 0;

        door8.k8 = 0;

        door9.k9 = 0;
        door10.k10 = 0;

        power2.power = 1;
        trigger2.istrigger = false;
        hasGameOverOccurred = false;


        endHealth = true;
        playerHealth.playerAlive = true;




        targetObject.transform.position = new Vector3(-12.21f, -7.24f, -0.01482391f);

    }
    public void mainmenu()
    {




        
        SceneManager.LoadScene("start  menu");


        endMenuUI.SetActive(false);
        




        

    }

    public void Quit()
    {
        Application.Quit();
    }
}
