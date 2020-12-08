using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class QuizManager : MonoBehaviour
{
    public int noSoal;
    Text soal;

    public string jawa;
    public Font hanacarakaFont;

    public Text yourText;

    public GameObject panelIntro, panelMenang, btnNext;
    public GameObject q1, q2, q3, q4, q5;

    void Start()
    {
        //label.GetComponent<Text>().font = hanacarakaFont;
        soal = GetComponent<Text>();
        //jawa.font = hanacarakaFont;

        //To load it:
        //Font font = Resources.Load("Fonts/Hanacaraka.ttf") as Font;

        panelMenang.gameObject.SetActive(false);

        //To assign it to the Text component:
        //yourText.font = font;

        //Menampilkan Intro
        panelIntro.gameObject.SetActive(true);
        //panelQuiz.gameObject.SetActive(false);

        //menampilkan soal mana yang ditampilkan / tidak
        q1.gameObject.SetActive(false);
        q2.gameObject.SetActive(false);
        q3.gameObject.SetActive(false);
        q4.gameObject.SetActive(false);
        q5.gameObject.SetActive(false);
    }

    void Update()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;


        //Script Lama (Abaikan)
        if(sceneName == "Stage1Kelas")
        {
            if (noSoal == 1)
            {
                soal.text = "Masukan Buku Kedalam Tas " + yourText;
            }

            else if (noSoal == 2)
            {
                soal.text = "Buang remasan kertas kedalam tempat sampah";
            }

            else if (noSoal == 3)
            {
                soal.text = "Masukkan penggaris kedalam kotak pensil";
            }

            else if (noSoal == 4)
            {
                soal.text = "Taruh Globe ke meja kiri";
            }

            else if (noSoal == 5)
            {
                soal.text = "Pasang Jam di tembok diatas Tanaman";
            }

            else
            {
                //Debug.Log("Menang");
            }
        }


        //Script Baru Untuk Menampilkan Soal Level 1
        if (sceneName == "NewStage1Kelas")
        {
            if (noSoal == 1)
            {
                soal.text = "Kamu Harus Menata Buku Kembali Ke Lemari";
                Debug.Log(soal.text);
                q1.gameObject.SetActive(true);
                q2.gameObject.SetActive(false);
                q3.gameObject.SetActive(false);
                q4.gameObject.SetActive(false);
                q5.gameObject.SetActive(false);
            }

            else if (noSoal == 2)
            {
                soal.text = "Kembalikan Sapu Pada Gantungannya";
                q1.gameObject.SetActive(false);
                q2.gameObject.SetActive(true);
                q3.gameObject.SetActive(false);
                q4.gameObject.SetActive(false);
                q5.gameObject.SetActive(false);
            }

            else if (noSoal == 3)
            {
                soal.text = "Tata Kembali Kursi di Dekat Meja Guru";
                q1.gameObject.SetActive(false);
                q2.gameObject.SetActive(false);
                q3.gameObject.SetActive(true);
                q4.gameObject.SetActive(false);
                q5.gameObject.SetActive(false);
            }

            else if (noSoal == 4)
            {
                soal.text = "Buanglah Kapur Pada Tempat Sampah";
                q1.gameObject.SetActive(false);
                q2.gameObject.SetActive(false);
                q3.gameObject.SetActive(false);
                q4.gameObject.SetActive(true);
                q5.gameObject.SetActive(false);
            }

            else if (noSoal == 5)
            {
                soal.text = "Tutuplah Gorden Pada Ruang Kelas";
                q1.gameObject.SetActive(false);
                q2.gameObject.SetActive(false);
                q3.gameObject.SetActive(false);
                q4.gameObject.SetActive(false);
                q5.gameObject.SetActive(true);
            }

            else if (noSoal == 6)
            {
                Debug.Log("Menang");
                SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
                q1.gameObject.SetActive(false);
                q2.gameObject.SetActive(false);
                q3.gameObject.SetActive(false);
                q4.gameObject.SetActive(false);
                q5.gameObject.SetActive(false);
            }
        }

        if (noSoal == 6)
        {
            //panelMenang.gameObject.SetActive(true);

            Debug.Log("Menang");
        }


    }

    public void masukQuiz()
    {
        panelIntro.gameObject.SetActive(false);
        btnNext.gameObject.SetActive(false);
    }
}
