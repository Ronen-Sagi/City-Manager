using UnityEngine;

public class BuildingBottonsScript : MonoBehaviour
{
    [SerializeField] private GameObject cityHall;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuildCityHall()
    {
        cityHall.SetActive(true);
    }
}
