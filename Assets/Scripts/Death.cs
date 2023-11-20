using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Death : MonoBehaviour
{
    public static int lives;
    public LevelManager reference;
    public TMPro.TextMeshProUGUI LivesText;
    // Start is called before the first frame update
    void Start()
    {
        lives = 5;
        LivesText.text = ("Vidas: "+lives);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            if (reference.level > 2)
            {
                other.gameObject.transform.position = reference.Pos_Respawn.position;
            }
            else {
                lives--;
                other.gameObject.transform.position = reference.Pos_Respawn.position;
                if (lives == 0)
                {
                    reference.Resestart();
                    lives = 5;
                }

            }
            
        }
        LivesText.text = ("Vidas: " + lives);
    }
}
