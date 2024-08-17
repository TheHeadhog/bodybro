using UnityEngine;

public class BodyPart : MonoBehaviour
{
    [System.Serializable]
    public class SpriteForStat
    {
        public float limit;
        public Sprite sprite;
    }

    [SerializeField] public float growthStat = 0;
    [SerializeField] private SpriteForStat[] spritesForStat;
    private SpriteRenderer spriteRenderer;

    public void ApplyModifier(float modifier)
    {
        growthStat += modifier;
    }

    private void UpdateSprite()
    {
        foreach (SpriteForStat sps in spritesForStat)
        {
            if(growthStat >= sps.limit)
            {
                spriteRenderer.sprite = sps.sprite;
            }
        }
    }
    
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        UpdateSprite();
    }
}
