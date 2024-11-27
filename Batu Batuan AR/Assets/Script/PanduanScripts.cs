using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PanduanScripts : MonoBehaviour
{
    [SerializeField] private Sprite[] panduanList;
    [SerializeField] private Image panduanImage;
    [SerializeField] private string[] panduanDescription;
    [SerializeField] private TMP_Text descriptionText;

    private int currentIndex = 0;

    void Start()
    {
        if (panduanList.Length > 0)
        {
            UpdateContent();
        }
    }

    public void NextImage()
    {
        if (panduanList.Length == 0) return;

        currentIndex++;
        if (currentIndex >= panduanList.Length)
        {
            currentIndex = 0; // kembali ke awal jika sudah di akhir
        }
        UpdateContent();
    }

    public void PreviousImage()
    {
        if (panduanList.Length == 0) return;

        currentIndex--;
        if (currentIndex < 0)
        {
            currentIndex = panduanList.Length - 1; // kembali ke akhir jika sudah di awal
        }
        UpdateContent();
    }

    private void UpdateContent()
    {
        panduanImage.sprite = panduanList[currentIndex];

        // Memastikan deskripsi tersedia
        if (currentIndex < panduanDescription.Length)
        {
            descriptionText.text = panduanDescription[currentIndex];
        }
        else
        {
            descriptionText.text = ""; // kosongkan jika deskripsi tidak ada
        }
    }
}
