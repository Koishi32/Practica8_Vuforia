using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelManager : MonoBehaviour
{
    public Transform pelota_Go;
    public GameObject []Laberint_Array;
    public Transform Pos_Respawn;
    public int level;
    public TMPro.TextMeshProUGUI LevelText;
    public GameObject Wining;
    int temp;
    // Start is called before the first frame update

    // Update is called once per frame
    private void Start()
    {
        level = 0;
         temp = level + 1;
        LevelText.text = "Nivel: " + temp;
        pelota_Go.transform.position = Pos_Respawn.position;
    }
    public void Win_level()
    {
        pelota_Go.transform.position = Pos_Respawn.position;
        level++;
        if (level >2) {
            Wining.SetActive (true);
        }
        else { 
        Laberint_Array[level-1].SetActive(false);
        Laberint_Array[level].SetActive(true);
        pelota_Go.transform.position = Pos_Respawn.position;
             temp = level + 1;
            LevelText.text = "Nivel: " + temp;
        }
    }
    public  void Resestart() {
        foreach (GameObject level in Laberint_Array) {
            level.SetActive(false);
        }
        Laberint_Array[0].SetActive(true);
        pelota_Go.transform.position = Pos_Respawn.position;
        level = 0;
        temp = level + 1;
        LevelText.text = "Nivel: " + temp;
    }

}
