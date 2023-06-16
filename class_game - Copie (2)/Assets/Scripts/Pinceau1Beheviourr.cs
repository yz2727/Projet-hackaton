using UnityEngine;

public class Pinceau1Behaviour : MonoBehaviour
{
    public GameObject pinceau1;
    public GameObject question1;

    private bool questionActive = false;

    void Start()
    {
        question1.SetActive(false);
        Debug.Log("Start() appelé");
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("objet détruit");

            if (!questionActive)
            {
                question1.SetActive(true);
                questionActive = true;
                Debug.Log("question active");
            }
        }
    }

    void Update()
    {
        Debug.Log("Update() appelé");
    }
}
