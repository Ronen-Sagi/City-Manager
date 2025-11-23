using TMPro;
using UnityEngine;

public class BuildingScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] int cost;
    protected int level;
    [SerializeField] TextMeshPro nameTag;
    [SerializeField] TextMeshPro levelTag;
    void Start()
    {
        this.level = 1;
        nameTag.text = transform.name;
        levelTag.text = "level: " + level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void LevelUp()
    {
        level++;
    }
}
