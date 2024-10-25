using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    [Serializable]
    class item
    {
        public string nama;
        [TextArea(5, 10)]
        public string materi;
        public int indexAR;
    }

    [SerializeField] item[] itemMateri;


    [Header("GUI")]
    public TextMeshProUGUI txtTitle;
    public TextMeshProUGUI txtMateri;
    public string sceneAR;

    [Header("Menu")]
    public GameObject[] menus;
    
    void Start()
    {
        PilihMateri(PlayerPrefs.GetInt("AR"));
        PilihMenu(PlayerPrefs.GetInt("PanelMenu"));
    }

    public void PilihMateri(int index)
    {
        txtTitle.text = itemMateri[index].nama;
        txtMateri.text = itemMateri[index].materi;
        PlayerPrefs.SetInt("AR", itemMateri[index].indexAR);
    }


    public void PilihMenu(int index)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            menus[i].SetActive(false);
        }

        menus[index].SetActive(true);
    }
}
