using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ProgramManager : MonoBehaviour
{
    public int task1Progress; 
    public int task2Progress; 
    public GameObject task2UI; 
    public GameObject endUI; 
    private AnimationController animController; 
    // Start is called before the first frame update
    void Start()
    {  
        task1Progress = 0; 
        task2Progress = 0; 
        animController = this.gameObject.GetComponent<AnimationController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (task1Progress == 3) { 
            task2UI.SetActive(true);
        } 

        if (task2Progress == 3) { 
            endUI.SetActive(true);
        }

        
    }

    public void Task1() { 
        animController.StartCoroutine("task1MovementCoroutine");
    } 

    public void Task2() { 
        animController.StartCoroutine("task2MovementCoroutine");
    } 

    public void Quit() { 
        Application.Quit();
    } 

    public void Restart()  {
        SceneManager.LoadScene("MainScene");
    }
}
