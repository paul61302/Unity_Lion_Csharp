﻿using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"),Range(0,100)]
    public float speed;
    [Header("傷害值"),Range(10,500)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    /// <summary>
    /// 移動
    /// </summary>
    protected void Move()
    {
        // Time.deltaTime
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    protected void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);        // 刪除怪物
        Destroy(exp, 0.5f);         // 2.5秒後刪除爆炸效果
    }

    protected virtual void Update()
    {
        Move();
    }

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(8, 8);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "房子")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }

}
