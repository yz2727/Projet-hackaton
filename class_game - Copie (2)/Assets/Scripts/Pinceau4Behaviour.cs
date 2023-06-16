using UnityEngine;

public class Pinceau4Behaviour : MonoBehaviour
{
    public GameObject pinceau4;
    public GameObject question4;

    private bool questionActive = false;

    void Start()
    {
        question4.SetActive(false);
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
                question4.SetActive(true);
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
