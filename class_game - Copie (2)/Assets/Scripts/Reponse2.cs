using UnityEngine;

public class Reponse2 : MonoBehaviour
{
    public GameObject question2;
    public GameObject arme;
    public AudioSource audioSource;
    public AudioClip correctAnswerSound;
    public AudioClip wrongAnswerSound;

    void Start()
    {
        arme.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.C))
        {
            audioSource.PlayOneShot(wrongAnswerSound);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            question2.SetActive(false);
            arme.SetActive(true);
            audioSource.PlayOneShot(correctAnswerSound);
        }
    }
}
