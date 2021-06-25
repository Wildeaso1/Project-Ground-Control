using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherScript : MonoBehaviour
{
    public GameObject motherBulletPrefab;
    public GameObject enemyDroidPrefab;

    private int attackNumber;
    private bool rolling = false;
    public bool inBattle = false;

    public GameObject motherShip;
    private MothershipHealth mHealth;

    private Transform turret1;
    private Transform turret2;
    private Transform turret3;
    private Transform turret4;
    private Transform turret5;

    private Transform bay1;
    private Transform bay2;
    private Transform bay3;
    private Transform bay4;
    private Transform bay5;

    // Start is called before the first frame update
    void Start()
    {
        turret1 = GameObject.Find("MBulletSpawn1").transform;
        turret2 = GameObject.Find("MBulletSpawn2").transform;
        turret3 = GameObject.Find("MBulletSpawn3").transform;
        turret4 = GameObject.Find("MBulletSpawn4").transform;
        turret5 = GameObject.Find("MBulletSpawn5").transform;

        bay1 = GameObject.Find("Bay1").transform;
        bay2 = GameObject.Find("Bay2").transform;
        bay3 = GameObject.Find("Bay3").transform;
        bay4 = GameObject.Find("Bay4").transform;
        bay5 = GameObject.Find("Bay5").transform;

        mHealth = motherShip.GetComponent<MothershipHealth>();

        inBattle = false;
        rolling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (mHealth.curHealth != 1000)
        {
            inBattle = true;
        }
        else
        {
            inBattle = false;
        }

        if (rolling == true && inBattle == true)
        {
            attackNumber = Random.Range(1, 3);
            switch (attackNumber)
            {
                case 1:
                    rolling = false;
                    StartCoroutine(TurretAttack());
                    break;
                case 2:
                    rolling = false;
                    StartCoroutine(DroidSpawn());
                    break;
                default:
                    break;
            }
        }
    }

    IEnumerator TurretAttack()
    {
        Instantiate(motherBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(motherBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(5.0f);
        rolling = true;
    }

    IEnumerator DroidSpawn()
    {
        Instantiate(enemyDroidPrefab, bay1.position, bay1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(enemyDroidPrefab, bay2.position, bay2.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(enemyDroidPrefab, bay3.position, bay3.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(enemyDroidPrefab, bay4.position, bay4.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(enemyDroidPrefab, bay5.position, bay5.rotation);
        yield return new WaitForSeconds(5.0f);
        rolling = true;
    }
}
