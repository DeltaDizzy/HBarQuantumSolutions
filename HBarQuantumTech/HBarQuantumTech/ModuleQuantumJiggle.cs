
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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
            Vector3d ForceDir = Random.onUnitSphere;
            return ForceDir;
        }

        public void JiggleGen()
        {
            /*foreach (Vessel currentVessel in FlightGlobals.VesselsLoaded)
            {
                //force = vessel mass: Force = vessel.GetTotalMass() * desiredAcceleration
                ForceToApply *= (currentVessel.GetTotalMass() * 5);
                this.part.AddForceAtPosition(ForceToApply, currentVessel.CoM);
            }*/
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
            this.JiggleGen();
        }
    }
}