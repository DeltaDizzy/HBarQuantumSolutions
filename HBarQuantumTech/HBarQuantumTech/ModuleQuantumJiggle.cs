﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace HBarQuantumTech
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    public class ModuleQuantumJiggle : PartModule
    {
        public static Vector3d ForceToApply;
        public static float speed;
        public static bool isJiggleActive = false;

        /*public static float SpeedGen()
        {
            float speed = Random.value;
            return speed;
        }*/
        public static Vector3d ForceDirGen()
        {
            Vector3d ForceDir = Random.onUnitSphere;
            return ForceDir;
        }

        public void JiggleGen()
        {
            int loadedVesselCount = FlightGlobals.VesselsLoaded.Count();
            for (int index = 0; index < loadedVesselCount; index++)
            {
                Vessel currentVessel = FlightGlobals.VesselsLoaded[index];
                ForceToApply *= (currentVessel.GetTotalMass() * 5 * TimeWarp.fixedDeltaTime);
                this.part.AddForceAtPosition(ForceToApply, currentVessel.CoM);
            }
        }
        public void FixedUpdate()
        {
           if(Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.K))
           {
                isJiggleActive = true;
           }
            if (isJiggleActive == true)
            {
                JiggleGen();
            }
        }
    }
}
