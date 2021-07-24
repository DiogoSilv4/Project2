using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;
using UnityEngine.UI;


public class Click_Menu : MonoBehaviour
{
    
    string scene_name;
    private bool onOFF;
    private void Start()
    {
        onOFF = false;
        CameraDevice.Instance.SetFlashTorchMode(onOFF);
    }
    private void Update()
    {
        
    }
    public void Playgame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        scene_name = "1_Start";
        SceneManager.LoadScene(scene_name);
    }
    public void BackOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    public void BackToStart()
    {
        scene_name = "1_Start";
        SceneManager.LoadScene(scene_name);
    }
   
    public void canvas()
    {
        scene_name = "5_Canvas";
        SceneManager.LoadScene(scene_name);        
    }
    public void Pyra()
    {
        scene_name = "2_Biome_Pyramid";
        SceneManager.LoadScene(scene_name);
    }
    public void pyramid_information()
    {
        scene_name = "4_Information";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Info", 1);
    }
    public void Selected_biome()
    {
        scene_name = "3_Selected_Biome";
        SceneManager.LoadScene(scene_name);
        
    }
    public void biome_information()
    {
        scene_name = "4_Information";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Info", 2);
    }
    public void plant_information()
    {
        scene_name = "4_Information";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Info", 3);
    }

    
    public void Back_information()
    {
        int screen;
        screen = PlayerPrefs.GetInt("Info");
        switch (screen)
        {
            case 1:
                scene_name = "2_Biome_Pyramid";
                SceneManager.LoadScene(scene_name);
                break;
            case 2:
                scene_name = "3_Selected_Biome";
                SceneManager.LoadScene(scene_name);
                break;
            case 3:
                scene_name = "5_Canvas";
                SceneManager.LoadScene(scene_name);
                break;
        }
        
    }
    public void Options()
    {
        scene_name = "1_Options";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Options", 1);
    }
    public void Fable()
    {
        scene_name = "1_Options";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Options",2);

    }
    public void Credits()
    {
        scene_name = "1_Options";
        SceneManager.LoadScene(scene_name);
        PlayerPrefs.SetInt("Options", 3);

    }
    
    public void toggle_flash()
    {
        if (!onOFF)
        {
            CameraDevice.Instance.SetFlashTorchMode(true);
            onOFF = true;
        }
        else
        {
            CameraDevice.Instance.SetFlashTorchMode(false);
            onOFF = false;
        }



    }
    

}
