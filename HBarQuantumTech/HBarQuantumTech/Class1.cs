
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using KSP.IO;

namespace HBarQuantumTech
{
    public class ModuleQuantumJiggle : PartModule
    {
        public static Vector3d ForceToApply;
        public static float speed;

        /*public static float SpeedGen()
        {
            float speed = Random.value;
            return speed;
        }*/
        public static Vector3d ForceDirGen()
        {
            Vector3d ForceToApply = Random.onUnitSphere * (FlightGlobals);
            return ForceToApply;
        }
        
        public void FixedUpdate()
        {
            foreach (Vessel currentVessel in FlightGlobals.VesselsLoaded)
            {
                this.part.AddForceAtPosition(ForceToApply, currentVessel.CoM);
            }
        }
    }
}