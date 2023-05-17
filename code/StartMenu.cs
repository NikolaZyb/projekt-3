using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private AudioSource collectionSoundEffect;
    
    public void Level_1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level_2()
    {
        SceneManager.LoadScene(2);
    }
    public void Level_3()
    {
        SceneManager.LoadScene(3);
    }
    public void MenuGame()
    {
        collectionSoundEffect.Play();
        SceneManager.LoadScene(0);
    }

}
