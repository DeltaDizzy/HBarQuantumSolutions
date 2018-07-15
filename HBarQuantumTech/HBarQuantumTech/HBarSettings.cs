using System;
using KSP.IO;
using UnityEngine;

namespace HBarQuantumTech
{
    public class HBarSettings : GameParameters.CustomParameterNode
    {
        [GameParameters.CustomParameterUI("Quantum Vibration Enabled", toolTip = "If enabled, all ships in physics range wil jiggle about due to quantum forces.")]
        public bool _jiggleEnabled = true;

        [GameParameters.CustomParameterUI("Quantum Vibration Enabled", toolTip = "If enabled, all ships in physics range wil jiggle about due to quantum forces.")]
        public static double JiggleForce = 1.0;

        public static bool JiggleEnabled
        {
            get
            {
                HBarSettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarSettings>();
                return settings._jiggleEnabled;
            }
            set
            {
                HBarSettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarSettings>();
                settings._jiggleEnabled = value;
            }
        }
    }
}
