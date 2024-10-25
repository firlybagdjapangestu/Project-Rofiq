using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArManager : MonoBehaviour
{
    [SerializeField] private StoneData[] stoneData;
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private TextMeshProUGUI descriptionText;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private GameObject descriptionImage;
    private AudioClip audioClip;
    private int StoneSelected;
    public int lenguageID;
    private bool isMusicPlaying = false; // Menandakan apakah musik sedang diputar

    // Start is called before the first frame update
    void Start()
    {
        // mengambil penyimpanan data
        StoneSelected = PlayerPrefs.GetInt("AR");
        lenguageID = PlayerPrefs.GetInt("LocaleKey");
        if (lenguageID == 0)
        {
            DisplayDescriptionFoundationEN();
        }
        else
        {
            DisplayDescriptionFoundationID();
        }
    }

    void DisplayDescriptionFoundationID() // fungsi menampilkan bahasa indonesia
    {

        titleText.text = stoneData[StoneSelected].namaBatu;
        descriptionText.text = stoneData[StoneSelected].deskripsiBatu;
        audioClip = stoneData[StoneSelected].suaraPenjelasanBatu;
    }

    void DisplayDescriptionFoundationEN() // fungsi menampilkan bahasa inggirs
    {
        titleText.text = stoneData[StoneSelected].stoneName;
        descriptionText.text = stoneData[StoneSelected].stoneDescription;
        audioClip = stoneData[StoneSelected].stoneSoundDescription;
    }

    public void ToggleMusic() // fungsi untuk mengeluarkan suara
    {
        if (isMusicPlaying)
        {
            audioSource.Stop();
        }
        else
        {
            audioSource.PlayOneShot(audioClip);
        }

        isMusicPlaying = !isMusicPlaying; // Mengubah status pemutaran musik
    }
    public void ToggleDescription() // fungsi untuk menampilkan deskripsi
    {
        if (descriptionImage.activeSelf) // Periksa apakah descriptionImage sedang aktif
        {
            descriptionImage.SetActive(false); // Jika aktif, nonaktifkan
        }
        else
        {
            descriptionImage.SetActive(true); // Jika tidak aktif, aktifkan
        }
    }
}
