using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagement : MonoBehaviour
{

    [SerializeField] private GameObject knikker;
    [SerializeField] private GameObject level;
    public string LevelToLoad;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Knikker"))
        {
            //Load next scene here (void voor maken)
            SceneManager.LoadScene(LevelToLoad);

        }   
    }
}
