using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneSelected : MonoBehaviour
{
    public StoneData[] stoneData;
    public int stoneSelected;
    // Start is called before the first frame update
    void Start()
    {
        stoneSelected = PlayerPrefs.GetInt("AR");
        GameObject obj = Instantiate(stoneData[stoneSelected].stonePrefabs, gameObject.transform.position, gameObject.transform.rotation);
        obj.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
