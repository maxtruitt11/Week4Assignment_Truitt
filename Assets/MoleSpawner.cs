using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    [SerializeField] Mole molePrefab;
    [SerializeField] float timeBetweenSpawns;
    [SerializeField] Mole moleButton;
    float spawnElapsed = 0;

    // Update is called once per frame
    void Update()
    {
        spawnElapsed += Time.deltaTime;

        if (spawnElapsed > timeBetweenSpawns)
        {
            SpawnMole();
            spawnElapsed = 0;
        }
    }

    private void SpawnMole()
    {
        Mole newMole = Instantiate(molePrefab);
        int r = Random.Range(-5, 5);
        newMole.transform.position = new Vector3(r, r, r);


        Destroy(molePrefab.gameObject);
        Destroy(moleButton, 1);
    }
}
