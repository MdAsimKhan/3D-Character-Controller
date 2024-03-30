using UnityEngine;

public class MobilePlayerController : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(Application.isMobilePlatform);
    }
}
