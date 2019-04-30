using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint orangeTurret;
    public TurretBlueprint greenTurret;
    public TurretBlueprint purpleTurret;
    public TurretBlueprint redTurret;
    public TurretBlueprint goldTurret;

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

   
    public void SelectOrangeTurret ()
    {
        Debug.Log("Orange Turret");
        buildManager.SelectTurretToBuild(orangeTurret);
    }

    public void SelectGreenTurret()
    {
        Debug.Log("Green Turret");
        buildManager.SelectTurretToBuild(greenTurret);
    }

    public void SelectPurpleTurret()
    {
        Debug.Log("Purple Turret");
        buildManager.SelectTurretToBuild(purpleTurret);
    }

    public void SelectRedTurret()
    {
        Debug.Log("Red Turret");
        buildManager.SelectTurretToBuild(redTurret);
    }

    public void SelectGoldTurret()
    {
        Debug.Log("Gold Turret");
        buildManager.SelectTurretToBuild(goldTurret);
    }

}
