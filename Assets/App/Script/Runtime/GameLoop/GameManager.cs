using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Title("Settings")] 
    [SerializeField] private string currentScene;
    [SerializeField] private Vector3 spawnOffset;

    [Title("Reference")] 
    [SerializeField] private GameObject startingPoint;
    [SerializeField] private RSO_TargetTransform rsoTargetPlayer;
    [SerializeField] private RSO_Life rsoLife;
    
    [Title("Input")]
    [SerializeField] private RSE_Win rseWin;

    private void Start()
    {
        rsoTargetPlayer.Value.GetComponent<Rigidbody>().position = startingPoint.transform.position + spawnOffset;
    }
    
    private void OnEnable()
    {
        rseWin.action += OnWin;
    }

    private void OnDisable()
    {
        rseWin.action -= OnWin;
    }
    
    private void OnWin()
    {
        SceneManager.LoadScene(currentScene);
    }

    
}