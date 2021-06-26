using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherScript : MonoBehaviour
{
    public MotherHealthBar HealthBar;

    public GameObject weakBulletPrefab;
    public GameObject weakDroidPrefab;

    public GameObject strongBulletPrefab;
    public GameObject strongDroidPrefab;

    public GameObject BGMusic;
    public GameObject BSMusic;

    private int attackNumber;
    private bool rolling = false;
    public bool inBattle = false;
    public static bool inZone = false;

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

        inZone = false;
        inBattle = false;
        rolling = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!inZone)
        {
            StartCoroutine(BossReset());
        }

        if (mHealth.curHealth != 1000 && inZone == true)
        {
            inBattle = true;
            BSMusic.SetActive(true);
            BGMusic.SetActive(false);
        }
        else
        {
            inBattle = false;
            BSMusic.SetActive(false);
            BGMusic.SetActive(true);
        }

        if (rolling == true && inBattle == true)
        {
            if (mHealth.curHealth >= 500)
            {
                attackNumber = Random.Range(1, 3);
                switch (attackNumber)
                {
                    case 1:
                        rolling = false;
                        StartCoroutine(TurretAttackWeak());
                        break;
                    case 2:
                        rolling = false;
                        StartCoroutine(DroidSpawnWeak());
                        break;
                    default:
                        break;
                }
            }
            if (mHealth.curHealth < 500)
            {
                attackNumber = Random.Range(1, 3);
                switch (attackNumber)
                {
                    case 1:
                        rolling = false;
                        StartCoroutine(TurretAttackStrong());
                        break;
                    case 2:
                        rolling = false;
                        StartCoroutine(DroidSpawnStrong());
                        break;
                    default:
                        break;
                }
            }
        }
    }

    IEnumerator BossReset()
    {
        yield return new WaitForSeconds(30f);
        if (!inZone)
        {
            mHealth.curHealth = 1000;
            HealthBar.SetHealth(mHealth.curHealth);
        }
    }

    IEnumerator TurretAttackWeak()
    {
        Instantiate(weakBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.4f);
        Instantiate(weakBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(5.0f);
        rolling = true;
    }

    IEnumerator TurretAttackStrong()
    {
        Instantiate(strongBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret1.position, turret1.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret2.position, turret2.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret3.position, turret3.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret4.position, turret4.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(strongBulletPrefab, turret5.position, turret5.rotation);
        yield return new WaitForSeconds(4.0f);
        rolling = true;
    }

    IEnumerator DroidSpawnWeak()
    {
        Instantiate(weakDroidPrefab, bay1.position, bay1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(weakDroidPrefab, bay2.position, bay2.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(weakDroidPrefab, bay3.position, bay3.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(weakDroidPrefab, bay4.position, bay4.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(weakDroidPrefab, bay5.position, bay5.rotation);
        yield return new WaitForSeconds(5.0f);
        rolling = true;
    }
    IEnumerator DroidSpawnStrong()
    {
        Instantiate(strongDroidPrefab, bay1.position, bay1.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(strongDroidPrefab, bay2.position, bay2.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(strongDroidPrefab, bay3.position, bay3.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(strongDroidPrefab, bay4.position, bay4.rotation);
        yield return new WaitForSeconds(0.1f);
        Instantiate(strongDroidPrefab, bay5.position, bay5.rotation);
        yield return new WaitForSeconds(4.0f);
        rolling = true;
    }
}
