using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KSP.IO;

namespace HBarQuantumTech
{
    class HBarDifficultySettings : GameParameters.CustomParameterNode
    {
        [GameParameters.CustomFloatParameterUI("QUantum Force Amount")]
        public double forceAmount = 5.0;

        [GameParameters.CustomParameterUI("Quantum Force Enabled", toolTip = "If this is checked, quatum force will be applied t every vessel within physics range.")]
        public bool forceEnabled = true;

        public static bool ForceEnabled
        {
            get
            {
                HBarDifficultySettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarDifficultySettings>();
                return settings.forceEnabled;
            }
            set
            {
                HBarDifficultySettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarDifficultySettings>();
                settings.forceEnabled = value;
            }
        }

        public static double ForceAmount
        {
            get
            {
                HBarDifficultySettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarDifficultySettings>();
                return settings.forceAmount;
            }
            set
            {
                HBarDifficultySettings settings = HighLogic.CurrentGame.Parameters.CustomParams<HBarDifficultySettings>();
                settings.forceAmount = value;
            }
        }

        public override string DisplaySection
        {
            get
            {
                return Section;
            }
        }
        public override string Section
        {
            get
            {
                return "HBar Quantum Solutions";
            }
        }
        public override string Title
        {
            get
            {
                return "Force Settings";
            }
        }
        public override int SectionOrder
        {
            get
            {
                return 1;
            }
        }
        public override GameParameters.GameMode GameMode
        {
            get
            {
                return GameParameters.GameMode.ANY;
            }
        }
        public override bool HasPresets
        {
            get
            {
                return false;
            }
        }
    }
}
