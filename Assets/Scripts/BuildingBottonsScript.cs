using UnityEngine;

public class BuildingBottonsScript : MonoBehaviour
{
    [SerializeField] private GameObject cityHall;
    [SerializeField] private GameObject hospital;
    [SerializeField] private GameObject School;
    private Building b;
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
        b = cityHall.GetComponent<Building>();
        Build();
    }
    
    public void BuildSchool()
    {
        b = School.GetComponent<Building>();
        Build();
    }
    public void BuildHospital()
    {
        b = hospital.GetComponent<Building>();
        Build();
    }

    public void Build()
    {
        if (ResourceManager.RM.Money >= b.Cost)
        {
            ResourceManager.RM.SpendMoney(b.Cost);
            b.ActivateBuilding();
            Debug.Log("Built " + b.name);
        }
    }
}
