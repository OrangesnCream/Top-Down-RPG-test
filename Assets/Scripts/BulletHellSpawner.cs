using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHellSpawner : MonoBehaviour
{
    public int numberOfColumns;
    public float speed;
    public Sprite texture;
    public Color color;
    public ParticleSystem system;
    public float lifetime;
    public float firerate;
    public float size;
    private float angle;
    public float spinSpeed;
    private float time;
    //stretches particles
    private ParticleSystemRenderMode renderMode = ParticleSystemRenderMode.Stretch;
    public Material material;
    private void Awake() {
        Summon();
    }
    private void FixedUpdate() {
        time += Time.fixedDeltaTime;
        transform.rotation = Quaternion.Euler(0, 0,time*spinSpeed);
    }
    void Summon() {
        angle = 360f / numberOfColumns;
        for (int i = 0; i < numberOfColumns; i++) {
            // A simple particle material with no texture.
            Material particleMaterial = material;
            // Create a green Particle System.
            var go = new GameObject("Particle System");
            go.transform.Rotate(angle*i, 90, 0); // Rotate so the system emits upwards.
            go.transform.parent = this.transform;
                go.transform.position = this.transform.position;
            system = go.AddComponent<ParticleSystem>();
            go.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
            //particle strecher 
            go.GetComponent<ParticleSystemRenderer>().renderMode = renderMode ;
            go.GetComponent<ParticleSystemRenderer>().alignment = ParticleSystemRenderSpace.Velocity;
            var mainModule = system.main;
            mainModule.startColor = Color.green;
            mainModule.startSize = 0.5f;
            mainModule.startSpeed = speed;
            mainModule.maxParticles = 1000000;
            mainModule.simulationSpace=ParticleSystemSimulationSpace.World;
            var emission = system.emission;
            emission.enabled = false;
            var form = system.shape;
            form.enabled = true;
            form.shapeType = ParticleSystemShapeType.Sprite;
            form.sprite = null;
            form.alignToDirection = true;
            var text = system.textureSheetAnimation;
            text.mode = ParticleSystemAnimationMode.Sprites;
            text.AddSprite(texture);
            text.enabled = true;
           
         
        }
        // Every 2 secs we will emit.
        InvokeRepeating("DoEmit", 0f, firerate);
    }

    void DoEmit() {
        // Any parameters we assign in emitParams will override the current system's when we call Emit.
        // Here we will override the start color and size.
        foreach (Transform child in transform) {
            system = child.GetComponent<ParticleSystem>();
            var emitParams = new ParticleSystem.EmitParams();
            emitParams.startColor = color;
            emitParams.startSize = size;
            emitParams.startLifetime = lifetime;
            system.Emit(emitParams, 10);
            system.Play(); // Continue normal emissions
        }
    }
}
