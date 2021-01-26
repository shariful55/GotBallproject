using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Manager : MonoBehaviour
{
    

    public void WelcomeToManu()
    {
        SceneManager.LoadScene(1);
    }

    public void StartToNew()
    {
        SceneManager.LoadScene(2);
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(2);
    }
    public void Level()
    {
        
    }
    public void Option()
    {
       Options.Instance.OptionManu3.gameObject.SetActive(true);
       Options.Instance.Cross.SetActive(true);

    }

    public void CrossOption()
    {
        Options.Instance.OptionManu3.SetActive(false);
        Options.Instance.Cross.SetActive(false);
    }


     public void Score()
    {
        SceneManager.LoadScene(4);

    }
    public void Exit()
    {
        Application.Quit();
        
    }
     public void GoToLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void BackToManu()
    {
        SceneManager.LoadScene(0);
    }
    public void SoundOFF()
    {
        SondManager.Instance.SoundOff();
        SoundButton.Instance.SoundOn.gameObject.SetActive(false);
        SoundButton.Instance.SoundOff.gameObject.SetActive(true);
    }
     public void SoundON()
    {
        SondManager.Instance.SoundONN();
        SoundButton.Instance.SoundOff.gameObject.SetActive(false);
        SoundButton.Instance.SoundOn.gameObject.SetActive(true);
    }

}
