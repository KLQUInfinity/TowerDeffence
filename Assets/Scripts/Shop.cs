using UnityEngine;

public class Shop : MonoBehaviour {

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance;
	}

	public void PurchaseStandardTurret ()
	{
		buildManager.SetTurrenToBuild(buildManager.standardTurretPrefab);
	}

	public void PurchaseMissileLauncher ()
	{
		buildManager.SetTurrenToBuild(buildManager.MissileLauncherPrefab);
	}
}
