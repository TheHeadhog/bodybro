using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimatedSpriteRenderer : MonoBehaviour
{
   private SpriteRenderer spriteRenderer;
   
   public Sprite idleSprite;
   public Sprite[] animationSprites;
   
   public float animationTime = 0.25f;
   private int animationFrame;
   
   public bool idle = true;
   private void Awake()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }

   private void OnEnable()
   {
      spriteRenderer.enabled = true;
   }

   private void OnDisable()
   {
      spriteRenderer.enabled = false;
   }

   private void Start()
   {
      InvokeRepeating(nameof(NextFrame), animationTime, animationTime);
   }

   private void NextFrame()
   {
      animationFrame = (animationFrame + 1) % animationSprites.Length;
      spriteRenderer.sprite = idle ? idleSprite : animationSprites[animationFrame];
   }
}
