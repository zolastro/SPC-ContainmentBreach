using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SCP_173_AI : MonoBehaviour {

    private Camera[] cameras;
    private Collider collider;
    private NavMeshAgent navMesh;
    private GameObject player;
    private BlinkService blinkService;


    void Start()
    {
        this.cameras = FindObjectsOfType<Camera>();
        this.collider = this.GetComponent<Collider>();
        this.player = GameObject.FindGameObjectWithTag("Player");
        this.blinkService = player.GetComponent<BlinkService>();
        this.navMesh = this.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        this.StalkPlayer();
    }


    private void StalkPlayer() {
        this.navMesh.destination = this.player.transform.position;
        this.navMesh.isStopped = this.isVisible(); 

    }

    private bool isVisible() {
        foreach (Camera cam in this.cameras) {
            if (isVisibleFromCamera(cam)) {
                return true;
            }
        }
        return false;
    }

    private bool isVisibleFromCamera(Camera camera) {
        if (!camera.isActiveAndEnabled || this.blinkService.isBlinking()) {
            return false;
        }
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes, this.collider.bounds);
    }
}
