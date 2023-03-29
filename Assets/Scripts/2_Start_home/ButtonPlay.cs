using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameVersion
{
    BERGAMO,
    BRESCIA
}

public enum GameLanguage
{
    ITALIANO,
    INGLESE
}

public class ButtonPlay : MonoBehaviour
{
    public GameVersion gameVersion=GameVersion.BERGAMO;
    public GameLanguage gameLanguage = GameLanguage.ITALIANO;

    public void EnableIta() => gameLanguage = GameLanguage.ITALIANO;
    public void EnableEng() => gameLanguage = GameLanguage.INGLESE;

    public void EnableBG() => gameVersion = GameVersion.BERGAMO;
    public void EnableBS() => gameVersion = GameVersion.BRESCIA;

    public int sceneID;

    public void Play()
    {
        if (gameLanguage== GameLanguage.ITALIANO)
        {
            //Siamo nella versione ITA
            if (gameVersion == GameVersion.BERGAMO)
            {
                //siamo nella versione di BG ITA
                //Carica scena
                SceneManager.LoadScene("1.5_Text_Ita_BG");
                Debug.Log("Siamo nella versione BG ITA");
            }

            else
            {
                //siamo nella versione di BS ITA
                //Carica scena
                SceneManager.LoadScene("1.5_Text_Ita_BS");
                Debug.Log("Siamo nella versione BS ITA");

            }
        }


        else
        {
            //Siamo nella versione ENG
            if (gameVersion == GameVersion.BERGAMO)
            {
                //siamo nella versione di BG ENG
                //Carica scena
                SceneManager.LoadScene("1.5_Text_Eng_BG");
                Debug.Log("Siamo nella versione BG ENG");
            }

            else
            {
                //siamo nella versione di BS ENG
                //Carica scena
                SceneManager.LoadScene("1.5_Text_Eng_BS");
                Debug.Log("Siamo nella versione BS ENG");
            }
        }
    }

}
