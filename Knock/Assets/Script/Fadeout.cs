using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fadeout : MonoBehaviour
{
    float alfa = 1;
    float speed = 0.01f;
    float red, green, blue;
    private bool FadeIn = true;
    private bool FadeOut = false;
    private bool doFade = true;
    private bool GoTitle = false;
    private bool Goknock = false;
    private AudioSource audioSource;

    void Start()
    {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (doFade == true)
        {
            if (FadeIn == true)
            {
                GetComponent<Image>().color = new Color(red, green, blue, alfa);
                alfa -= speed;

                if (alfa <= 0)
                {
                    doFade = false;
                    FadeIn = !FadeIn;
                    FadeOut = !FadeOut;
                }
            }

            if (FadeOut == true)
            {
                GetComponent<Image>().color = new Color(red, green, blue, alfa);
                alfa += speed;
                if(Goknock == true)
                {
                    audioSource.Play();

                }

                if (alfa >= 1)
                {
                    FadeIn = !FadeIn;
                    FadeOut = !FadeOut;

                    if (Goknock == true)
                    {
                        SceneManager.LoadScene("Main");
                    }

                    if (GoTitle == true)
                    {
                        SceneManager.LoadScene("Start");
                    }
                }
            }
        }
        else
        {
            if(Input.GetMouseButtonDown(0))
            {
                Goknock = true;
                doFade = true;
            }

            if (Input.GetMouseButtonDown(1))
            {
                GoTitle = true;
                doFade = true;
            }

        }
    }

}