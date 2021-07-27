namespace SRTDevilMayCry4DirectX
{
    public class PluginConfiguration
    {
        public bool Debug { get; set; }
        public bool ShowHPBars { get; set; }
        public bool ShowIGT { get; set; }
        public float ScalingFactor { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float EnemyHPPositionX { get; set; }
        public float EnemyHPPositionY { get; set; }
        public string IGTString { get; set; }
        public string DevilTriggerString { get; set; }
        public string StringFontName { get; set; }
        public string EnemyString { get; set; }
        public string VersionInfoString { get; set; }
        public string GameInfoString { get; set; }

        public PluginConfiguration()
        {
            Debug = true;
            ShowHPBars = true;
            ShowIGT = true;
            ScalingFactor = 1f;
            PositionX = 5f;
            PositionY = 30f;
            EnemyHPPositionX = -1;
            EnemyHPPositionY = -1;
            IGTString = "IGT:";
            DevilTriggerString = "Devil Trigger:";
            StringFontName = "Courier New";
            EnemyString = "ENEMY HP";
            VersionInfoString = "Version:";
            GameInfoString = "Game Version:";
        }
    }
}
