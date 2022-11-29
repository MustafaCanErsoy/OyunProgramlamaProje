using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    Durdurma durdurma;
    [SerializeField] float seviyeGecikmesi = 1f;
    void Start() 
    {

    }

   public void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Bitis":
                InisBaslat();
                break;
            case "Baslangic":
                break;
            default:
                CarpmaBaslat();
                break;
        }
    }

    public void InisBaslat()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("SeviyeTekrarla", seviyeGecikmesi);
    }

    public void CarpmaBaslat()
    {
        GetComponent<Movement>().enabled = false;
        Invoke("SeviyeTekrarla", seviyeGecikmesi);
    }


    public void SeviyeTekrarla()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

}
