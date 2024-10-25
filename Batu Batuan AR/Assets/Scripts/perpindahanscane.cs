using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class perpindahanscane : MonoBehaviour
{
    
    void Start()
    {

    }

    public void BackToMenu()
    {
        PlayerPrefs.SetInt("Home", 1);

        SceneManager.LoadScene("Home");
    }

    public void BackToPanelMenu()
    {
        SceneManager.LoadScene("Home");
        PlayerPrefs.SetInt("PanelMenu", 2);
    }

    public void LoadToScene(string SceneName)
    {
        PlayerPrefs.SetInt("Home", 0);
        
        SceneManager.LoadScene (SceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnApplicationQuit()
    {
        // Hapus semua data di PlayerPrefs
        PlayerPrefs.DeleteAll();
        PlayerPrefs.Save(); // Pastikan perubahan disimpan sebelum aplikasi benar-benar ditutup
        Debug.Log("Semua data PlayerPrefs telah dihapus saat aplikasi keluar.");
        Application.Quit();
    }
}

