using Assets.Scripts.Interfaces;
using UnityEngine;

public class Meteorite : MonoBehaviour, IKillable
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Die();
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
