using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuManager : MonoBehaviour
{
    public TMP_Text Namapanel;
   public void Loadscene(string Namascene)
    {
        SceneManager.LoadScene(Namascene);
    }

    public void SetNamaPanel(string nama)
    {
        Namapanel.text = nama;
    }

    public void KeluarAplikasi()
    {
        Application.Quit();
    }
}
