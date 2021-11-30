using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhuziController : MonoBehaviour
{
    public GameObject ZhuziPrefab;
    public Transform Zhuzis;
    public GammeM gm;
    public float spawnTime = 2f;
    public bool ZhuziIsMOve = true;
    private List<GameObject> zhuzis = new List<GameObject>();
    public void Start()
    {
        StartCoroutine(SpawnZhuzi());
    }
    /// <summary>
    /// 开始柱子的移动
    /// </summary>
    public void StartMove()
    {
        ZhuziIsMOve = true;
        foreach (GameObject item in zhuzis)
        {
            item.GetComponent<ZhuiziScripe>().canMove = true;
            
        }

    }
    /// <summary>
    /// 停止柱子的移动
    /// </summary>
    public void StopMove()
    {
        ZhuziIsMOve = false;
        foreach (GameObject item in zhuzis)
        {
            item.GetComponent<ZhuiziScripe>().canMove = false;
        }
        

    }
    public void SpawnOneZhuzi()
    {
        GameObject zhuzi =  GameObject.Instantiate(ZhuziPrefab, Zhuzis);
        zhuzi.GetComponent<ZhuiziScripe>().RandomHeight();
        zhuzis.Add(zhuzi);
       // Destroy(zhuzi, 5f);
    }
    
    IEnumerator SpawnZhuzi()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTime);
            if (!gm.isGameStart) continue;
            if (!ZhuziIsMOve) continue;
            SpawnOneZhuzi();
        
        }
    }
 
    
}
