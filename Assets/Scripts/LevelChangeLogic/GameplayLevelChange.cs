using UnityEngine;

public class GameplayLevelChange : MonoBehaviour
{
    [SerializeField] private GameObject levelChangeShip;

    [SerializeField] private int enemiesCount;
    [SerializeField] private int enemiesEliminated;

    private void Start()
    {
        enemiesCount = GameObject.FindGameObjectsWithTag("Enemies").Length;
    }

    public void EnemiesEliminated()
    {
        enemiesEliminated += 1;

        if (enemiesEliminated == enemiesCount)
        {
            levelChangeShip.SetActive(true);
        }
    }
}
