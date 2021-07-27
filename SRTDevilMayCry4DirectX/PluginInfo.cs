using SRTPluginBase;
using System;

namespace SRTDevilMayCry4DirectX
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "DirectX Overlay UI (Devil May Cry 4 Special Edition)";

        public string Description => "A DirectX-based Overlay User Interface for displaying Devil May Cry 4 Special Edition game memory values.";

        public string Author => "VideoGameRoulette";

        public Uri MoreInfoURL => new Uri("https://github.com/SpeedrunTooling/SRTDevilMayCry4DirectX");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
